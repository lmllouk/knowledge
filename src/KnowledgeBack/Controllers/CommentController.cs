using System;
using Microsoft.AspNet.Mvc;

namespace KnowledgeBack.Controllers
{
    [Route("api/v1/comment")]
    public class CommentController : Controller
    {
        [HttpGet]
        [Route("list/all")]
        public IAsyncResult GetAllComment() {
            return null;
        }
        
        /// <summary>
        /// ナレッジ項目単位でコメントを取得する
        /// </summary>
        /// <param name="knowledgeNo">ナレッジ キーNo</param>
        /// <returns></returns>
        [HttpGet]
        [Route("list/knowledge/{knowledgeNo}")]
        public IAsyncResult GetComment(int knowledgeNo) {
            return null;
        }
        
        /// <summary>
        /// 指定コメントを取得する
        /// </summary>
        /// <param name="commentNo">コメントNo</param>
        /// <returns></returns>
        [HttpGet]
        [Route("list/{commentNo}")]
        public IAsyncResult GetCommentId(int commentNo) {
            return null;
        }
        
        /// <summary>
        /// コメントの登録
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IAsyncResult PostComment() {
            return null;
        }
        
        /// <summary>
        /// コメントの編集
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("edit")]
        public IAsyncResult PutComment() {
            return null;
        }
    }
}