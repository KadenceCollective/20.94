﻿using System.Net.Http;
using UngerboeckSDKWrapper;
using UngerboeckSDKPackage;
using System.Collections.Generic;

namespace Examples.Operations
{
  public class Departments : Base
  {
    public Departments(HttpClient USISDKClient) : base(USISDKClient)
    {
    }

    /// <summary>
    /// A basic retrieve example
    /// </summary> 
    public DepartmentsModel Get(string orgCode, string code)
    {
      return APIUtil.GetDepartments(USISDKClient, orgCode, code);
    }

    /// <summary>
    /// A retrieve all.  We recommend using a specific query when searching, shown in the General class.
    /// </summary> 
    public IEnumerable<DepartmentsModel> RetrieveAll(string orgCode)
    {
      SearchMetadataModel searchMetadata = null;
      return APIUtil.GetSearchList<DepartmentsModel>(USISDKClient, ref searchMetadata, orgCode, "All");
    }
  }
}
