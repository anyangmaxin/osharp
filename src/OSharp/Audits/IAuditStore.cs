﻿// -----------------------------------------------------------------------
//  <copyright file="IAuditStore.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-12-31 1:26</last-date>
// -----------------------------------------------------------------------

using System.Collections.Generic;

using OSharp.Dependency;


namespace OSharp.Audits
{
    /// <summary>
    /// 定义Audit数据存储功能
    /// </summary>
    public interface IAuditStore
    {
        /// <summary>
        /// 设置实体审计数据
        /// </summary>
        /// <param name="auditDatas"></param>
        void SetAuditDatas(IEnumerable<AuditEntity> auditDatas);
    }


    /// <summary>
    /// 空的Audit存储，什么也不做
    /// </summary>
    public class NullAuditStore : IAuditStore, ISingletonDependency
    {
        /// <summary>
        /// 设置实体审计数据
        /// </summary>
        /// <param name="auditDatas"></param>
        public void SetAuditDatas(IEnumerable<AuditEntity> auditDatas)
        { }
    }
}