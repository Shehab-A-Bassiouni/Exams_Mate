using Examination_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Examination_System.Managers
{
	public static class LoginManager
	{
		public static int UserID;
		public static int UserType;
		public static int UserTypeID;
		public static ITI_Exam_SystemContext ctx = new();

		public static void Login(string userName , string password) {

			var parameters = new[]
		   {
	new SqlParameter("@username", userName),
	new SqlParameter("@password", password),
	new SqlParameter("@user_id", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output },
	new SqlParameter("@user_type", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output },
	new SqlParameter("@user_type_id", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output }
};

			var output = ctx.Database.ExecuteSqlRaw("EXEC Verify_Login @username, @password, @user_id OUTPUT, @user_type OUTPUT, @user_type_id OUTPUT", parameters);

			UserID = (int)parameters[2].Value;
			UserType = (int)parameters[3].Value;
			UserTypeID = (int)parameters[4].Value;
		}
	}
}
