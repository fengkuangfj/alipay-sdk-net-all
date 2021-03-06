using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberAlipaybigcardQueryResponse.
    /// </summary>
    public class AlipayUserMemberAlipaybigcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝大卡片展现信息（缓存类），缓存类是对实时性要求不高的透出内容。缓存类用于存在缓存中，在调用接口超时或者降级时取用。
        /// </summary>
        [XmlElement("alipay_big_card_cache_data")]
        public BigCardData AlipayBigCardCacheData { get; set; }

        /// <summary>
        /// 支付宝大卡片展现信息（实时），展现层数据信息，结构详见具体复杂类型，返回给用户的卡片展现信息包括实时类和缓存类两部分，实时类是精确信息，直接用于前端展现
        /// </summary>
        [XmlElement("alipay_big_card_real_time_data")]
        public BigCardData AlipayBigCardRealTimeData { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 业务失败是否可重试
        /// </summary>
        [XmlElement("retryable")]
        public string Retryable { get; set; }

        /// <summary>
        /// 是否业务处理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
