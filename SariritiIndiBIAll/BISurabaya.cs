using SpssLib.DataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SariritiIndiBIAll
{
    class BISurabaya
    {
        internal void runBISurabaya()
        {
            var variablesmap = new Dictionary<string, string>();

            int SurveyID = 600624;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-09-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_BiallSariroti iobj = new DB_insertion_BiallSariroti();
            string questions = "id,weight,B28b1,B28b2,B28b3,B28b4,B28b5,B28b6,B28b7,B28b8,B28b9,B28b10,B28b11,B28b12,B28b13,B28b14,B28b15,B28b16,B28b17,B28b18,B28b19,B28b20,B28b21,B28b22,B28b23";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SRINDI\BI\SRInd_Surabaya-final-sep18.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
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
                    string B28b1 = "-- Not Available --";
                    string B28b2 = "-- Not Available --";
                    string B28b3 = "-- Not Available --";
                    string B28b4 = "-- Not Available --";
                    string B28b5 = "-- Not Available --";
                    string B28b6 = "-- Not Available --";
                    string B28b7 = "-- Not Available --";
                    string B28b8 = "-- Not Available --";
                    string B28b9 = "-- Not Available --";
                    string B28b10 = "-- Not Available --";
                    string B28b11 = "-- Not Available --";
                    string B28b12 = "-- Not Available --";
                    string B28b13 = "-- Not Available --";
                    string B28b14 = "-- Not Available --";
                    string B28b15 = "-- Not Available --";
                    string B28b16 = "-- Not Available --";
                    string B28b17 = "-- Not Available --";
                    string B28b18 = "-- Not Available --";
                    string B28b19 = "-- Not Available --";
                    string B28b20 = "-- Not Available --";
                    string B28b21 = "-- Not Available --";
                    string B28b22 = "-- Not Available --";
                    string B28b23 = "-- Not Available --";

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
                                    case "B28b1": {  B28b1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b2": {  B28b2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b3": {  B28b3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b4": {  B28b4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b5": {  B28b5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b6": {  B28b6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b7": {  B28b7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b8": {  B28b8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b9": {  B28b9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b10": { B28b10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b11": { B28b11 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b12": { B28b12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b13": { B28b13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b14": { B28b14 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b15": { B28b15 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b16": { B28b16 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b17": { B28b17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b18": { B28b18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b19": { B28b19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b20": { B28b20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b21": { B28b21 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b22": { B28b22 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B28b23": { B28b23 = Convert.ToString(record.GetValue(variable)); break; }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_BISurabaya_values(userID, SurveyID, AttendedOn, Weight, country, B28b1,B28b2,B28b3,B28b4,B28b5,B28b6,B28b7,B28b8,B28b9,B28b10,B28b11,B28b12,B28b13,B28b14,B28b15,B28b16,B28b17,B28b18,B28b19,B28b20,B28b21,B28b22,B28b23);
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
