namespace Xero.NetStandard.OAuth2.Test.Helpers
{
    using Xunit;
    using System;
    using System.Reflection;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;
    using Xero.NetStandard.OAuth2.Api;
    using Xero.NetStandard.OAuth2.Model;
    using Xero.NetStandard.OAuth2.Client;
    using Newtonsoft.Json;
    using RestSharp;
    using System.Text;

    public abstract class StringTest<T>{
      
        public void TestStrings(string value, string expected){
            // Get property names of object
            List<string> propertyNames = GetPropertyNames();
            var response = new RestResponse();
            
            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            // Loop through property names and inputed values and construct JSON string
            int count = propertyNames.Count();
            foreach(string s in propertyNames){
                sb.Append("\"");
                sb.Append(s);
                sb.Append("\": \"");
                sb.Append(value);
                sb.Append("\"");
                if (count > 1) sb.Append(",");
                count--;
            }
            sb.Append("}");
        
            // Final JSON string
            response.Content = sb.ToString();
                

            var deserializer = new CustomJsonCodec(new Configuration());
            var model = deserializer.Deserialize<T>(response);
            
            // For every property specified in GetPropertyNames() run a unit test against
            for(int i = 0; i < propertyNames.Count(); i++){
                // Check if the deserialised value is the same as the expected value
                if (expected != GetPropertyValue(model, propertyNames[i])){
                    throw new Exception("Failed Unit Test");
                }
            }
        }

        // Get the value of a property from an 
        public static string GetPropertyValue(object obj, string propName) { 
            return (string)obj.GetType().GetProperty(propName).GetValue(obj, null); 
        }

        public virtual List<string> GetPropertyNames(){
            List<string> propertyNames = new List<string>();

            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach(PropertyInfo prop in properties){
                propertyNames.Add(prop.Name);
            }
            return propertyNames;
        }
    }
}
