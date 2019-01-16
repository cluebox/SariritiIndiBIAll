using SpssLib.DataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SariritiIndiBIAll
{
    class BIJabodetabek
    {
        internal void runBIJabodetabek()
        {
            var variablesmap = new Dictionary<string, string>();

            int SurveyID = 600627;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-09-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_BiallSariroti iobj = new DB_insertion_BiallSariroti();
            string questions = "id,weight,B28a1,B28a2,B28a3,B28a4,B28a5,B28a6,B28a7,B28a8,B28a9,B28a10,B28a11,B28a12,B28a13,B28a14,B28a15,B28a16,B28a17,B28a18,B28a19,B28a20,B28a21,B28a22,B28a23";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SRINDI\BI\SRInd_Jabodetabek-final-sep18.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                                //iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, country, BASE_VARIABLE_NAME, AttendedOn);
                            }
                        }

                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string variable_name;
                    string userID = null;
                    string u_id = null;
                    decimal Weight = 0;
                    string B28a1 = "-- Not Available --";
                    string B28a2 = "-- Not Available --";
                    string B28a3 = "-- Not Available --";
                    string B28a4 = "-- Not Available --";
                    string B28a5 = "-- Not Available --";
                    string B28a6 = "-- Not Available --";
                    string B28a7 = "-- Not Available --";
                    string B28a8 = "-- Not Available --";
                    string B28a9 = "-- Not Available --";
                    string B28a10 = "-- Not Available --";
                    string B28a11 = "-- Not Available --";
                    string B28a12 = "-- Not Available --";
                    string B28a13 = "-- Not Available --";
                    string B28a14 = "-- Not Available --";
                    string B28a15 = "-- Not Available --";
                    string B28a16 = "-- Not Available --";
                    string B28a17 = "-- Not Available --";
                    string B28a18 = "-- Not Available --";
                    string B28a19 = "-- Not Available --";
                    string B28a20 = "-- Not Available --";
                    string B28a21 = "-- Not Available --";
                    string B28a22 = "-- Not Available --";
                    string B28a23 = "-- Not Available --";

                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;

                                switch (variable_name)
                                {
                                    case "id":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, AttendedOn, u_id);
                                            break;
                                        }
                                    case "weight":
                                        {
                                            Weight = Convert.ToDecimal(record.GetValue(variable));
                                            break;
                                        }
                                    case "B28a1": { B28a1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a2": { B28a2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a3": { B28a3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a4": { B28a4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a5": { B28a5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a6": { B28a6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a7": { B28a7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a8": { B28a8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a9": { B28a9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a10": { B28a10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a11": { B28a11 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a12": { B28a12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a13": { B28a13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a14": { B28a14 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a15": { B28a15 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a16": { B28a16 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a17": { B28a17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a18": { B28a18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a19": { B28a19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a20": { B28a20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a21": { B28a21 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a22": { B28a22 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28a23": { B28a23 = Convert.ToString(record.GetValue(variable)); break; }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_BIJabodetabek_values(userID, SurveyID, AttendedOn, Weight, country, B28a1, B28a2, B28a3, B28a4, B28a5, B28a6, B28a7, B28a8, B28a9, B28a10, B28a11, B28a12, B28a13, B28a14, B28a15, B28a16, B28a17, B28a18, B28a19, B28a20, B28a21, B28a22, B28a23);
                    }


                }
            }
        }
        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
}
