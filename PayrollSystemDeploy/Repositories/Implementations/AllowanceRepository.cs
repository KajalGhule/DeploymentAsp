using PayrollWebApp.DataBaseConnection;
using PayrollWebApp.DTO;
using PayrollWebApp.Repositories.Interface;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace PayrollWebApp.Repositories
{
    public class AllowanceRepository : IAllowanceRepository
    {
        private readonly DbHelper _dbHelper;

        public AllowanceRepository(DbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }


        public async Task<List<AllowanceDTO>> GetAllAllowances()
        {
            List<AllowanceDTO> allowances = new List<AllowanceDTO>();
            string query = @"SELECT AllowanceID, AllowanceName, Percentage, Description, Amount, IncludeInForm16, Form16Section, IncludeInGross,AllowanceType  FROM PR_AllowancesMaster WHERE Deleted='N'";

            SqlConnection connection = await _dbHelper.GetConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    int AllowanceID = Convert.ToInt32(reader["AllowanceID"].ToString());
                    string AllowanceName = reader["AllowanceName"].ToString();
                    decimal Percentage = Convert.ToDecimal(reader["Percentage"]);
                    double Amount = reader["Amount"] == DBNull.Value ? 0.0: Convert.ToDouble(reader["Amount"]);
                    String Description = reader["Description"].ToString();
                    //bool IncludeInForm16 = Convert.ToBoolean(reader["IncludeInForm16"]);
                    string Form16Section = reader["Form16Section"]?.ToString();
                    bool? IncludeInForm16 = reader["IncludeInForm16"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(reader["IncludeInForm16"]);
                    string IncludeInGross = reader["IncludeInGross"] == DBNull.Value ? null : reader["IncludeInGross"].ToString();
                    string AllowanceType = reader["AllowanceType"] == DBNull.Value ? null : reader["AllowanceType"].ToString();

                    AllowanceDTO allowance = new AllowanceDTO();
                    allowance.AllowanceID = AllowanceID;
                    allowance.AllowanceName = AllowanceName;
                    allowance.Percentage = Percentage;
                    allowance.Description = Description;
                    allowance.Amount = Amount;
                    allowance.IncludeInForm16 = IncludeInForm16;
                    allowance.Form16Section = Form16Section;
                    allowance.IncludeInGross = IncludeInGross;
                    allowance.AllowanceType = AllowanceType;

                    allowances.Add(allowance);
                }
                await reader.CloseAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                await connection.CloseAsync();
            }
            return allowances;
        }

        public async Task<bool> UpdateAllowance(AllowanceDTO dto)
        {

            using (SqlConnection conn = await _dbHelper.GetConnection())
            {
                string query = @"UPDATE PR_AllowancesMaster
                         SET AllowanceName = @Name,
                             Amount = @Amount,
                             Description = @Description,
                             Percentage = @Percentage,
                             IncludeInForm16 = @IncludeInForm16,
                             Form16Section = @Form16Section,
                             IncludeInGross = @IncludeInGross,
                             AllowanceType = @AllowanceType,
                             TrUser = @TrUser,
                             TrDate = @TrDate
                         WHERE AllowanceID = @AllowanceID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AllowanceID", dto.AllowanceID);
                    cmd.Parameters.AddWithValue("@Name", dto.AllowanceName);
                    cmd.Parameters.AddWithValue("@Amount", dto.Amount.HasValue ? dto.Amount.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Percentage", dto.Percentage);
                    cmd.Parameters.AddWithValue("@Description", dto.Description ?? (object)DBNull.Value);
                    //cmd.Parameters.AddWithValue("@IncludeInForm16", dto.IncludeInForm16 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IncludeInForm16", dto.IncludeInForm16 ?? false);
                    //cmd.Parameters.AddWithValue("@Form16Section", dto.Form16Section ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Form16Section", string.IsNullOrEmpty(dto.Form16Section) ? (object)DBNull.Value : dto.Form16Section);

                    cmd.Parameters.AddWithValue("@IncludeInGross", string.IsNullOrEmpty(dto.IncludeInGross) ? (object)DBNull.Value : dto.IncludeInGross);
                    cmd.Parameters.AddWithValue("@AllowanceType", string.IsNullOrEmpty(dto.AllowanceType) ? (object)DBNull.Value : dto.AllowanceType);

                    cmd.Parameters.AddWithValue("@TrUser", dto.TrUser);
                    cmd.Parameters.AddWithValue("@TrDate", dto.TrDate);

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    return rowsAffected > 0; 
                }
            }
        }

        public async Task<bool> DeleteAllowance(int id)
        {
            using (SqlConnection conn = await _dbHelper.GetConnection())
            {
                //UPDATE PR_AllowancesMaster SET Deleted = 'Y WHERE DepartmentID = @DepartmentID
                string query = "UPDATE PR_AllowancesMaster SET Deleted = 'Y' WHERE AllowanceID = @AllowanceID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AllowanceID", id);

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    return rowsAffected > 0; // true if deleted, false if not found
                }
            }
        }

        public async Task<int> AddAllowance(AllowanceDTO dto)
        {

            using (SqlConnection conn = await _dbHelper.GetConnection())
            {
                string query = @"INSERT INTO PR_AllowancesMaster (AllowanceName, Description, Percentage, Amount, IncludeInForm16, Form16Section,IncludeInGross, AllowanceType, CrUser, CrDate, Deleted)
                         VALUES (@AllowanceName, @Description,@Percentage, @Amount, @IncludeInForm16, @Form16Section, @IncludeInGross, @AllowanceType, @CrUser, @CrDate, @Deleted);
                         SELECT SCOPE_IDENTITY();"; 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AllowanceName", dto.AllowanceName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(dto.Description) ? (object)DBNull.Value : dto.Description);
                    cmd.Parameters.AddWithValue("@Percentage", dto.Percentage);
                    cmd.Parameters.AddWithValue("@Amount", dto.Amount.HasValue ? dto.Amount.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IncludeInForm16", dto.IncludeInForm16 ?? false);
                    cmd.Parameters.AddWithValue("@Form16Section", string.IsNullOrEmpty(dto.Form16Section) ? (object)DBNull.Value : dto.Form16Section);

                    // Values directly from frontend (dto)
                    cmd.Parameters.AddWithValue("@IncludeInGross", string.IsNullOrEmpty(dto.IncludeInGross) ? (object)DBNull.Value : dto.IncludeInGross);
                    cmd.Parameters.AddWithValue("@AllowanceType", string.IsNullOrEmpty(dto.AllowanceType) ? (object)DBNull.Value : dto.AllowanceType);

                    cmd.Parameters.AddWithValue("@CrUser", dto.CrUser);
                    cmd.Parameters.AddWithValue("@CrDate", dto.CrDate);
                    cmd.Parameters.AddWithValue("@Deleted", dto.Deleted);

                    object result = await cmd.ExecuteScalarAsync();

                    return Convert.ToInt32(result); // return new allowance ID
                }
            }
        }

        public async Task<AllowanceDTO?> GetAllowanceById(int id)
        {
            using (SqlConnection conn = await _dbHelper.GetConnection())
            {
                string query = @"SELECT AllowanceID, AllowanceName, Amount, Description, Percentage, IncludeInForm16, Form16Section, IncludeInGross,AllowanceType  
                         FROM PR_AllowancesMaster 
                         WHERE AllowanceID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new AllowanceDTO
                            {
                                AllowanceID = Convert.ToInt32(reader["AllowanceID"]),
                                AllowanceName = reader["AllowanceName"].ToString() ?? string.Empty,
                                Amount = reader["Amount"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Amount"]),
                                Description = reader["Description"] == DBNull.Value ? null : reader["Description"].ToString(),
                                Percentage = reader["Percentage"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Percentage"]),
                                //IncludeInForm16 = Convert.ToBoolean(reader["IncludeInForm16"]),
                                //Form16Section = reader["Form16Section"]?.ToString(),
                                IncludeInForm16 = reader["IncludeInForm16"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(reader["IncludeInForm16"]),
                                Form16Section = reader["Form16Section"] == DBNull.Value ? null : reader["Form16Section"].ToString(),
                                
                                IncludeInGross = reader["IncludeInGross"] == DBNull.Value ? null : reader["IncludeInGross"].ToString(),
                                AllowanceType = reader["AllowanceType"] == DBNull.Value ? null : reader["AllowanceType"].ToString(),

                            };
                        }
                    }
                }
            }

            return null; // not found
        }

    }
}
