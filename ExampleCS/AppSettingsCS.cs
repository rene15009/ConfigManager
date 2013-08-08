 
using System;
using System.Configuration;
using System.Collections.Generic;
//-------------------------------------------------------------------------------------------------------------
//Notas este código fue generado por la plantilla AppSettings.tt cualquier cambio debe hacerse en la misma
//Generado: 08/08/2013 16:59:18
//-------------------------------------------------------------------------------------------------------------
    public static class Settings {


        public static string Uno
        {
            get { return ConfigurationManager.AppSettings["Uno"]; }		
        }

        public static string Dos
        {
            get { return ConfigurationManager.AppSettings["Dos"]; }		
        }

        public static string Tres
        {
            get { return ConfigurationManager.AppSettings["Tres"]; }		
        }

        public static string Cuatro
        {
            get { return ConfigurationManager.AppSettings["Cuatro"]; }		
        }

        public static string Some_Property
        {
            get { return ConfigurationManager.AppSettings["Some:Property"]; }		
        }

        public static string Webpages_Version
        {
            get { return ConfigurationManager.AppSettings["Webpages:Version"]; }		
        }

        public static string Webpages_Enabled
        {
            get { return ConfigurationManager.AppSettings["Webpages Enabled"]; }		
        }

        public static string Preserve_LoginUrl
        {
            get { return ConfigurationManager.AppSettings["Preserve-LoginUrl"]; }		
        }

        public static string ClientValñidationEnabled
        {
            get { return ConfigurationManager.AppSettings["ClientValñidationEnabled"]; }		
        }

        public static string Unobtrusiv_JavaScriptEnabled
        {
            get { return ConfigurationManager.AppSettings["Unobtrusiv JavaScriptEnabled"]; }		
        }
        
        public List< KeyValuePair<string, string>> GetListSettings()
        {
                var l= new List<KeyValuePair<string, string>>();     
           
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));
            l.Add(new KeyValuePair<string, string>("uno","dos"));

                return l;           
        }	

       } //end class

 
