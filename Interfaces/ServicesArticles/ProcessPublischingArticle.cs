using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ServicesArticles
{
    public class ProcessPublischingArticle : IProcessPublischingArticle
    {

        private readonly IAddContentInArticle _addContentInArticle;
        private readonly ICheckArticleOnErrors _checkArticleOnErrors;
        private readonly IPublishArticle _publishArticle;
        public ProcessPublischingArticle (
            IAddContentInArticle addContentInArticle,
            ICheckArticleOnErrors checkArticleOnErrors,
            IPublishArticle publishArticle
            )
        {
            _addContentInArticle = addContentInArticle;
            _checkArticleOnErrors = checkArticleOnErrors;
            _publishArticle = publishArticle;
        }
       

        void IProcessPublischingArticle.ProcessPublischingArticle()
        {
            _addContentInArticle.AddContentInArticle();
            _checkArticleOnErrors.CheckArticleOnErrors();
            _publishArticle.PublishArticle();
        }
    }
}
