﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionDirecTv.ServicesDirecTV
{
    public class INT015b
    {
        public static void GetINT015b()
        {
            var url = $"https://directvprd.ocasa.com/DtvSap/api/DirecTvINT015b";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }
    }
}
