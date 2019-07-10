using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4jJsonImporter
{
    public class RelatedIssue
    {
        public string lawName { get; set; }
        public string issueRef { get; set; }
    }

    public class Party
    {
        public List<string> group { get; set; }
        public string title { get; set; }
        public string value { get; set; }
    }

    public class JDG
    {
        public string court { get; set; }
        public DateTime date { get; set; }
        public string no { get; set; }
        public string sys { get; set; }
        public string reason { get; set; }
        public string judgement { get; set; }
        public string type { get; set; }
        public string historyHash { get; set; }
        public string mainText { get; set; }
        public string opinion { get; set; }
        //public string relatedIssues { get; set; }
        //public string party { get; set; }
        //public List<RelatedIssue> relatedIssues { get; set; }
        //public List<Party> party { get; set; }
    }
}
