using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeBack.Models
{
    /// <summary>
    /// ナレッジベースデータ
    /// </summary>
    public class Knowledge
    {
        /// <summary>
        /// ナレッジNo
        /// </summary>
        [Column("knowledge_id")]
        public long KnowledgeId { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [Column("title")]
        public string Title { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        [Column("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Column("content")]
        public string Content { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; }
    }
}
