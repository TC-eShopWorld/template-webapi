using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebApi.template.Models
{
    public abstract class BaseDto
    {
        private readonly List<Link> _links = new List<Link>();

        [JsonProperty(Order = 100)]
        public IEnumerable<Link> Links => _links;

        public void AddLink(Link link)
        {
            if(link!=null)
                _links.Add(link);
        }

        public void AddLinks(params Link[] links)
        {
            foreach (Link link in links)
            {
                AddLink(link);
            }
        }
    }
}