﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionDirecTv.ServicesIntegracionDTV
{
    public class TransferOrder
    {
        public static void GetTRansferORder()
        {
            //var url = $"http://localhost:44300/api/DirecTvINT008";
            var url = $"https://directvprd.ocasa.com/Integracion-Dtv/AsnTeorico/TransferOrder";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
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
                throw ex;
            }
        }
    }
}


