﻿using System;
namespace jafleet.Commons.Constants
{
    public static class OperationCode
    {
        /// <summary>
        /// 予約登録
        /// </summary>
        public const string RESERVED = "0";

        /// <summary>
        /// 製造中
        /// </summary>
        public const string MAKING = "1";

        /// <summary>
        /// デリバリー
        /// </summary>
        public const string DELIVERY = "2";

        /// <summary>
        /// 国際
        /// </summary>
        public const string INTERNATIONAL = "3";

        /// <summary>
        /// 国内
        /// </summary>
        public const string DOMESTIC = "4";

        /// <summary>
        /// 併用
        /// </summary>
        public const string BOTH = "5";

        /// <summary>
        /// 貨物
        /// </summary>
        public const string CARGO = "6";

        /// <summary>
        /// 退役（未抹消）
        /// </summary>
        public const string RETIRE_REGISTERED = "7";

        /// <summary>
        /// 退役（抹消）
        /// </summary>
        public const string RETIRE_UNREGISTERED = "8";

        /// <summary>
        /// 運用前
        /// </summary>
        public static readonly string[] PRE_OPERATION = new string[] { RESERVED, MAKING, DELIVERY };

        /// <summary>
        /// 運用中
        /// </summary>
        public static readonly string[] IN_OPERATION = new string[] { INTERNATIONAL, DOMESTIC, BOTH, CARGO };

        /// <summary>
        /// 退役
        /// </summary>
        public static readonly string[] RETIRE = new string[] { RETIRE_REGISTERED, RETIRE_UNREGISTERED };


    }
}
