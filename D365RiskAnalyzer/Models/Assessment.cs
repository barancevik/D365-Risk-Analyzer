using System;
using System.Collections.Generic;
using System.Text;

namespace D365RiskAnalyzer.Models
{
    public class Assessment
    {

        public string CompanyName { get; set; }
        public string ProjectName { get; set; }
        public int RiskScore { get; set; }
        public string RiskLevel { get; set; }
        public DateTime CreatedDate { get; set; }



    }
}
