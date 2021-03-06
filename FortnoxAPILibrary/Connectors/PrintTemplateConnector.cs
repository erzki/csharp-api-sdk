﻿
using System.Collections.Generic;
namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class PrintTemplateConnector : EntityConnector<PrintTemplates, PrintTemplates, Sort.By.PrintTemplate>
	{
		/// <remarks/>
		public PrintTemplateConnector(string accessToken, string clientSecret) : base(accessToken, clientSecret)
        {
			base.Resource = "printtemplates";
		}

        /// <remarks/>
        public PrintTemplateConnector() : this(null, null)
        {
        }

        /// <summary>
        /// Gets a list of print templates
        /// </summary>
        /// <returns>A list of print templates</returns>
        public PrintTemplates Find()
		{
			return base.BaseFind();
		}
	}
}
