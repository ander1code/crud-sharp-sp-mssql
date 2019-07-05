using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace libCRUD
{
    public class Controller
    {
        #region Attributes
        private PhysicalPerson pp;
        private UserSys user;
        private SqlConnection conn;
        private SqlCommand cmd;
        #endregion

        #region Constructors
        public Controller()
        {
            this.conn = Connection.Connect();
        }

        public Controller(PhysicalPerson pp)
        {
            this.conn = Connection.Connect();
            this.pp = pp;
        }

        public Controller(UserSys user)
        {
            this.conn = Connection.Connect();
            this.user = user;
        }
        #endregion

        #region Search for PhysicalPerson
        public List<PhysicalPerson> GetPhysicalPerson_ByName()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SELECT * FROM FC_GET__PHYSICALPERSON_BYNAME(@NAME)";
                this.cmd.Parameters.AddWithValue("@NAME", this.pp.Name + '%');
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    List<PhysicalPerson> list = new List<PhysicalPerson>();
                    while (sqr.Read())
                    {
                        PhysicalPerson p = new PhysicalPerson();
                        p.Id = sqr.GetInt32(0);
                        p.Name = sqr.GetString(1);
                        p.Email = sqr.GetString(2);
                        p.Salary = sqr.GetDecimal(3);
                        p.DateBirth = sqr.GetDateTime(4);
                        p.Genre = sqr.GetString(5)[0];
                        list.Add(p);
                    }
                    return list;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PhysicalPerson GetPhysicalPerson_ByID()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SELECT * FROM FC_GET__PHYSICALPERSON_BYID(@ID)";
                this.cmd.Parameters.AddWithValue("@ID", this.pp.Id);
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    PhysicalPerson p = new PhysicalPerson();
                    sqr.Read();
                    p.Id = sqr.GetInt32(0);
                    p.Name = sqr.GetString(1);
                    p.Email = sqr.GetString(2);
                    p.Salary = sqr.GetDecimal(3);
                    p.DateBirth = sqr.GetDateTime(4);
                    p.Genre = sqr.GetString(5)[0];
                    return p;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Reports
        public List<PhysicalPerson> GetPhysicalPerson_SalaryAboveAVG()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SP_GET__PHYSICALPERSON_SAL_ABOVEAVG";
                this.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    List<PhysicalPerson> list = new List<PhysicalPerson>();
                    while (sqr.Read())
                    {
                        PhysicalPerson p = new PhysicalPerson();
                        p.Id = sqr.GetInt32(0);
                        p.Name = sqr.GetString(1);
                        p.Email = sqr.GetString(2);
                        p.Salary = sqr.GetDecimal(3);
                        p.DateBirth = sqr.GetDateTime(4);
                        p.Genre = sqr.GetString(5)[0];
                        list.Add(p);
                        sqr.NextResult();
                    }
                    return list;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PhysicalPerson> GetPhysicalPerson_SalaryUnderAVG()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SP_GET__PHYSICALPERSON_SAL_UNDERAVG";
                this.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    List<PhysicalPerson> list = new List<PhysicalPerson>();
                    while (sqr.Read())
                    {
                        PhysicalPerson p = new PhysicalPerson();
                        p.Id = sqr.GetInt32(0);
                        p.Name = sqr.GetString(1);
                        p.Email = sqr.GetString(2);
                        p.Salary = sqr.GetDecimal(3);
                        p.DateBirth = sqr.GetDateTime(4);
                        p.Genre = sqr.GetString(5)[0];
                        list.Add(p);
                        sqr.NextResult();
                    }
                    return list;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PhysicalPerson> GetPhysicalPerson_SalaryEqualAVG()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SP_GET__PHYSICALPERSON_SAL_EQUALAVG";
                this.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    List<PhysicalPerson> list = new List<PhysicalPerson>();
                    while (sqr.Read())
                    {
                        PhysicalPerson p = new PhysicalPerson();
                        p.Id = sqr.GetInt32(0);
                        p.Name = sqr.GetString(1);
                        p.Email = sqr.GetString(2);
                        p.Salary = sqr.GetDecimal(3);
                        p.DateBirth = sqr.GetDateTime(4);
                        p.Genre = sqr.GetString(5)[0];
                        list.Add(p);
                        sqr.NextResult();
                    }
                    return list;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PhysicalPerson GetPhysicalPerson_HigherSalary()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SP_GET__PHYSICALPERSON_HIGHERSAL";
                this.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    PhysicalPerson p = new PhysicalPerson();
                    sqr.Read();
                    p.Id = sqr.GetInt32(0);
                    p.Name = sqr.GetString(1);
                    p.Email = sqr.GetString(2);
                    p.Salary = sqr.GetDecimal(3);
                    p.DateBirth = sqr.GetDateTime(4);
                    p.Genre = sqr.GetString(5)[0];
                    return p;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PhysicalPerson GetPhysicalPerson_LowerSalary()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SP_GET__PHYSICALPERSON_LOWSAL";
                this.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    PhysicalPerson p = new PhysicalPerson();
                    sqr.Read();
                    p.Id = sqr.GetInt32(0);
                    p.Name = sqr.GetString(1);
                    p.Email = sqr.GetString(2);
                    p.Salary = sqr.GetDecimal(3);
                    p.DateBirth = sqr.GetDateTime(4);
                    p.Genre = sqr.GetString(5)[0];
                    return p;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PhysicalPerson> GetPhysicalPerson_ByBirthMonth(int month)
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SELECT * FROM FC_GET__PHYSICALPERSON_BYMONTHDATEBIRTH(@MONTH)";
                this.cmd.Parameters.Add(new SqlParameter("@MONTH", month));
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    List<PhysicalPerson> list = new List<PhysicalPerson>();
                    while (sqr.Read())
                    {
                        PhysicalPerson p = new PhysicalPerson();
                        p.Id = sqr.GetInt32(0);
                        p.Name = sqr.GetString(1);
                        p.Email = sqr.GetString(2);
                        p.Salary = sqr.GetDecimal(3);
                        p.DateBirth = sqr.GetDateTime(4);
                        p.Genre = sqr.GetString(5)[0];
                        list.Add(p);
                    }
                    return list;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PhysicalPerson> GetPhysicalPerson_BySalaryRange(decimal sal1, decimal sal2)
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SELECT * FROM FC_GET__PHYSICALPERSON_BYSALARYRANGE(@SAL1, @SAL2)";
                this.cmd.Parameters.Add(new SqlParameter("@SAL1", sal1));
                this.cmd.Parameters.Add(new SqlParameter("@SAL2", sal2));
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    List<PhysicalPerson> list = new List<PhysicalPerson>();
                    while (sqr.Read())
                    {
                        PhysicalPerson p = new PhysicalPerson();
                        p.Id = sqr.GetInt32(0);
                        p.Name = sqr.GetString(1);
                        p.Email = sqr.GetString(2);
                        p.Salary = sqr.GetDecimal(3);
                        p.DateBirth = sqr.GetDateTime(4);
                        p.Genre = sqr.GetString(5)[0];
                        list.Add(p);
                    }
                    return list;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetCountPhysicalPerson_ByGenre(char genre)
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.CommandText = "SELECT * FROM FC_GET__COUNTPHYSICALPERSON_BYGENRE(@GENRE)";
                this.cmd.Parameters.Add(new SqlParameter("@GENRE", genre));
                this.cmd.CommandType = CommandType.StoredProcedure;
                return (int)this.cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region TO LOG
        public int ToLog_UserSys()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.AddWithValue("@USERNAME", this.user.Username);
                this.cmd.Parameters.AddWithValue("@USERPASS", this.user.Userpass);
                this.cmd.CommandText = "SP_TOLOG";
                this.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqr = this.cmd.ExecuteReader();
                if (sqr.HasRows)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        
        #region Transactions
        public int Insert_PhysicalPerson_tr()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.Add(new SqlParameter("@NAME", this.pp.Name));
                this.cmd.Parameters.Add(new SqlParameter("@EMAIL", this.pp.Email));
                this.cmd.Parameters.Add(new SqlParameter("@SALARY", this.pp.Salary));
                this.cmd.Parameters.Add(new SqlParameter("@DATEBIRTH", this.pp.DateBirth));
                this.cmd.Parameters.Add(new SqlParameter("@GENRE", this.pp.Genre));
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.CommandText = "INSERT__PHYSICALPERSON";
                this.cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Edit_PhysicalPerson_tr()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.Add(new SqlParameter("@ID", this.pp.Id));
                this.cmd.Parameters.Add(new SqlParameter("@NAME", this.pp.Name));
                this.cmd.Parameters.Add(new SqlParameter("@EMAIL", this.pp.Email));
                this.cmd.Parameters.Add(new SqlParameter("@SALARY", this.pp.Salary));
                this.cmd.Parameters.Add(new SqlParameter("@DATEBIRTH", this.pp.DateBirth));
                this.cmd.Parameters.Add(new SqlParameter("@GENRE", this.pp.Genre));
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.CommandText = "EDIT__PHYSICALPERSON";
                this.cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Delete_PhysicalPerson_tr()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.Add(new SqlParameter("@ID", this.pp.Id));
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.CommandText = "DELETE__PHYSICALPERSON";
                this.cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private int Insert_Login_tr(Int32 user_id)
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.Add(new SqlParameter("@ID", this.pp.Id));
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.CommandText = "INSERT__USERSYS_LOGIN";
                this.cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Insert_UserSys_tr()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.Add(new SqlParameter("@USERNAME", this.user.Username));
                this.cmd.Parameters.Add(new SqlParameter("@USERPASS", this.user.Userpass));
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.CommandText = "INSERT__USERSYS";
                this.cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Delete_UserSys_tr()
        {
            try
            {
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.conn;
                this.cmd.Parameters.Add(new SqlParameter("@ID", this.user.Id));
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.CommandText = "SP_DELETE__USERSYS";
                this.cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        #endregion
    }
}