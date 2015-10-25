using HTMH_Parser.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HTMH_Parser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ParsingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ParsingService.svc or ParsingService.svc.cs at the Solution Explorer and start debugging.
    public class ParsingService : IParsingService
    {
        public List<Article> getAllArticles(Uri webSiteLink)
        {
            return Parser.getArticles(webSiteLink);
        }
    }
}
