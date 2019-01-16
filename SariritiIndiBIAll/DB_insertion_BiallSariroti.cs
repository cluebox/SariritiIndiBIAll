using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SariritiIndiBIAll
{
    class DB_insertion_BiallSariroti
    {
        SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
        internal void insert_Dashboard_variable_values(string VARIABLE_NAME, string VARIABLE_NAME_SUB_NAME, string VARIABLE_ID, string VARIABLE_VALUE, string VARIABLE_NAME_QUESTION, int SurveyID, string country, string BASE_VARIABLE_NAME, string AttendedOn)
        {
            String VARIABLEVALUE = VARIABLE_VALUE.Replace("'", "");
            String VARIABLE_QUESTION = VARIABLE_NAME_QUESTION.Replace("'", "");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardSPS_Variable_Values (VARIABLE_NAME,VARIABLE_NAME_SUB_NAME,VARIABLE_ID,VARIABLE_VALUE,VARIABLE_NAME_QUESTION,SURVEY_ID,SURVEY_COUNTRY,BASE_VARIABLE_NAME,SURVEY_PERIOD) " + "VALUES('" + VARIABLE_NAME + "','" + VARIABLE_NAME_SUB_NAME + "','" + VARIABLE_ID + "','" + VARIABLEVALUE + "','" + VARIABLE_QUESTION + "','" + SurveyID + "','" + country + "','" + BASE_VARIABLE_NAME + "','" + AttendedOn + "')", connection);
            try
            {


                cmd.ExecuteNonQuery();
                Console.WriteLine("Dashboard variable values inserted successfully");

                connection.Close();



            }
            catch (Exception)
            {

                Console.WriteLine("Exception occured");
                Console.ReadLine();
            }
        }

        internal void insert_BIBandung_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string B28c1, string B28c2, string B28c3, string B28c4, string B28c5, string B28c6, string B28c7, string B28c8, string B28c9, string B28c10, string B28c11, string B28c12, string B28c13, string B28c14, string B28c15, string B28c16, string B28c17, string B28c18, string B28c19, string B28c20, string B28c21, string B28c22, string B28c23)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_Indi_BI_Bandung_temp (UserID,SurveyID,AttendedOn,weight,Country,B28c1,B28c2,B28c3,B28c4,B28c5,B28c6,B28c7,B28c8,B28c9,B28c10,B28c11,B28c12,B28c13,B28c14,B28c15,B28c16,B28c17,B28c18,B28c19,B28c20,B28c21,B28c22,B28c23) " + "VALUES('" + userID + "','" + SurveyID + "','" + AttendedOn + "','" + Weight + "','" + country + "','" + B28c1 + "','" + B28c2 + "','" + B28c3 + "','" + B28c4 + "','" + B28c5 + "','" + B28c6 + "','" + B28c7 + "','" + B28c8 + "','" + B28c9 + "','" + B28c10 + "','" + B28c11 + "','" + B28c12 + "','" + B28c13 + "','" + B28c14 + "','" + B28c15 + "','" + B28c16 + "','" + B28c17 + "','" + B28c18 + "','" + B28c19 + "','" + B28c20 + "','" + B28c21 + "','" + B28c22 + "','" + B28c23 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_BISurabaya_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string B28b1, string B28b2, string B28b3, string B28b4, string B28b5, string B28b6, string B28b7, string B28b8, string B28b9, string B28b10, string B28b11, string B28b12, string B28b13, string B28b14, string B28b15, string B28b16, string B28b17, string B28b18, string B28b19, string B28b20, string B28b21, string B28b22, string B28b23)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_Indi_BI_Surabaya_temp (UserID,SurveyID,AttendedOn,weight,Country,B28b1,B28b2,B28b3,B28b4,B28b5,B28b6,B28b7,B28b8,B28b9,B28b10,B28b11,B28b12,B28b13,B28b14,B28b15,B28b16,B28b17,B28b18,B28b19,B28b20,B28b21,B28b22,B28b23) " + "VALUES('" + userID + "','" + SurveyID + "','" + AttendedOn + "','" + Weight + "','" + country + "','" + B28b1 + "','" + B28b2 + "','" + B28b3 + "','" + B28b4 + "','" + B28b5 + "','" + B28b6 + "','" + B28b7 + "','" + B28b8 + "','" + B28b9 + "','" + B28b10 + "','" + B28b11 + "','" + B28b12 + "','" + B28b13 + "','" + B28b14 + "','" + B28b15 + "','" + B28b16 + "','" + B28b17 + "','" + B28b18 + "','" + B28b19 + "','" + B28b20 + "','" + B28b21 + "','" + B28b22 + "','" + B28b23 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_BIJabodetabek_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string B28a1, string B28a2, string B28a3, string B28a4, string B28a5, string B28a6, string B28a7, string B28a8, string B28a9, string B28a10, string B28a11, string B28a12, string B28a13, string B28a14, string B28a15, string B28a16, string B28a17, string B28a18, string B28a19, string B28a20, string B28a21, string B28a22, string B28a23)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_Indi_BI_Jabodetabek_temp (UserID,SurveyID,AttendedOn,weight,Country,B28a1,B28a2,B28a3,B28a4,B28a5,B28a6,B28a7,B28a8,B28a9,B28a10,B28a11,B28a12,B28a13,B28a14,B28a15,B28a16,B28a17,B28a18,B28a19,B28a20,B28a21,B28a22,B28a23) " + "VALUES('" + userID + "','" + SurveyID + "','" + AttendedOn + "','" + Weight + "','" + country + "','" + B28a1 + "','" + B28a2 + "','" + B28a3 + "','" + B28a4 + "','" + B28a5 + "','" + B28a6 + "','" + B28a7 + "','" + B28a8 + "','" + B28a9 + "','" + B28a10 + "','" + B28a11 + "','" + B28a12 + "','" + B28a13 + "','" + B28a14 + "','" + B28a15 + "','" + B28a16 + "','" + B28a17 + "','" + B28a18 + "','" + B28a19 + "','" + B28a20 + "','" + B28a21 + "','" + B28a22 + "','" + B28a23 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }
    }
}
