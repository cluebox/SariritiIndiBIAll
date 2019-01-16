using SpssLib.DataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SariritiIndiBIAll
{
    class BIBandung
    {
        internal void runBIBandung()
        {
            var variablesmap = new Dictionary<string, string>();

            int SurveyID = 600628;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-09-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_BiallSariroti iobj = new DB_insertion_BiallSariroti();
            string questions = "id,weight,S9,S8,S2,B28c1,B28c2,B28c3,B28c4,B28c5,B28c6,B28c7,B28c8,B28c9,B28c10,B28c11,B28c12,B28c13,B28c14,B28c15,B28c16,B28c17,B28c18,B28c19,B28c20,B28c21,B28c22,B28c23";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SRINDI\BI\SRInd_Bandung-final-sep18.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
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
                    string B28c1 = "-- Not Available --";
                    string B28c2 = "-- Not Available --";
                    string B28c3 = "-- Not Available --";
                    string B28c4 = "-- Not Available --";
                    string B28c5 = "-- Not Available --";
                    string B28c6 = "-- Not Available --";
                    string B28c7 = "-- Not Available --";
                    string B28c8 = "-- Not Available --";
                    string B28c9 = "-- Not Available --";
                    string B28c10 = "-- Not Available --";
                    string B28c11 = "-- Not Available --";
                    string B28c12 = "-- Not Available --";
                    string B28c13 = "-- Not Available --";
                    string B28c14 = "-- Not Available --";
                    string B28c15 = "-- Not Available --";
                    string B28c16 = "-- Not Available --";
                    string B28c17 = "-- Not Available --";
                    string B28c18 = "-- Not Available --";
                    string B28c19 = "-- Not Available --";
                    string B28c20 = "-- Not Available --";
                    string B28c21 = "-- Not Available --";
                    string B28c22 = "-- Not Available --";
                    string B28c23 = "-- Not Available --";

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
                                    case "B28c1": { B28c1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c2": { B28c2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c3": { B28c3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c4": { B28c4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c5": { B28c5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c6": { B28c6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c7": { B28c7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c8": { B28c8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c9": { B28c9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c10": { B28c10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c11": { B28c11 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c12": { B28c12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c13": { B28c13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c14": { B28c14 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c15": { B28c15 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c16": { B28c16 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c17": { B28c17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c18": { B28c18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c19": { B28c19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c20": { B28c20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c21": { B28c21 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c22": { B28c22 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28c23": { B28c23 = Convert.ToString(record.GetValue(variable)); break; }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_BIBandung_values(userID, SurveyID, AttendedOn, Weight, country, B28c1, B28c2, B28c3, B28c4, B28c5, B28c6, B28c7, B28c8, B28c9, B28c10, B28c11, B28c12, B28c13, B28c14, B28c15, B28c16, B28c17, B28c18, B28c19, B28c20, B28c21, B28c22, B28c23);
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
