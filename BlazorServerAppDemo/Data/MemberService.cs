using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace BlazorServerAppDemo.Data
{
    public class MemberService
    {
        private readonly string _connectionString;

        public MemberService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "Select * from Members";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            members.Add(new Member
                            {

                            });
                        }
                    }
                }
            }
            return members;
        }
        public Member GetMembersById(string memberId)
        {
            Member member = new ();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = $"Select * from Members where memberId = {memberId}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            member = new Member
                            {

                            };
                        }
                    }
                }
            }
            return member;
        }

    }

}
