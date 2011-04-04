// Copyright 2011, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

using Google.Api.Ads.Common.Lib;

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Api.Ads.AdWords.Lib {
  /// <summary>
  /// Lists all the services available through this library.
  /// </summary>
  public partial class AdWordsService : AdsService {
    /// <summary>
    /// All the services available in v201008.
    /// </summary>
    public class v201008 {
      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/AdExtensionOverrideService.html">
      /// this page </a> for details.
      /// </summary>
      public static readonly ServiceSignature AdExtensionOverrideService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/AdGroupAdService.html">
      /// this page </a> for details.
      /// </summary>
      public static readonly ServiceSignature AdGroupAdService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/AdGroupCriterionService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature AdGroupCriterionService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/AdGroupService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature AdGroupService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/AdParamService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature AdParamService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/AlertService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature AlertService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/BidLandscapeService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature BidLandscapeService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/BulkMutateJobService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature BulkMutateJobService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/CampaignAdExtensionService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature CampaignAdExtensionService;
      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/CampaignCriterionService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature CampaignCriterionService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/CampaignService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature CampaignService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/CampaignTargetService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature CampaignTargetService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/CustomerSyncService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature CustomerSyncService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/ExperimentService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature ExperimentService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/GeoLocationService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature GeoLocationService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/InfoService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature InfoService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/MediaService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature MediaService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/ReportDefinitionService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature ReportDefinitionService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/ServicedAccountService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature ServicedAccountService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/TargetingIdeaService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature TargetingIdeaService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/TrafficEstimatorService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature TrafficEstimatorService;

      /// <summary>
      /// See <a href="http://code.google.com/apis/adwords/v2009/docs/reference/UserListService.html">
      /// this page</a> for details.
      /// </summary>
      public static readonly ServiceSignature UserListService;

      /// <summary>
      /// Factory type for v201008 services.
      /// </summary>
      public static readonly Type factoryType = typeof(AdWordsServiceFactory);

      /// <summary>
      /// Static constructor to initialize the service constants.
      /// </summary>
      static v201008() {
        AdExtensionOverrideService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "AdExtensionOverrideService");
        AdGroupAdService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "AdGroupAdService");
        AdGroupCriterionService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "AdGroupCriterionService");
        AdGroupService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "AdGroupService");
        AdParamService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "AdParamService");
        AlertService =
            AdWordsService.MakeServiceSignature("v201008", "mcm", "AlertService");
        BidLandscapeService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "BidLandscapeService");
        BulkMutateJobService =
            AdWordsService.MakeServiceSignature("v201008", "job", "BulkMutateJobService");
        CampaignAdExtensionService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "CampaignAdExtensionService");
        CampaignCriterionService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "CampaignCriterionService");
        CampaignService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "CampaignService");
        CampaignTargetService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "CampaignTargetService");
        CustomerSyncService =
            AdWordsService.MakeServiceSignature("v201008", "ch", "CustomerSyncService");
        ExperimentService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "ExperimentService");
        GeoLocationService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "GeoLocationService");
        InfoService =
            AdWordsService.MakeServiceSignature("v201008", "info", "InfoService");
        MediaService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "MediaService");
        ReportDefinitionService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "ReportDefinitionService");
        ServicedAccountService =
            AdWordsService.MakeServiceSignature("v201008", "mcm", "ServicedAccountService");
        TargetingIdeaService =
            AdWordsService.MakeServiceSignature("v201008", "o", "TargetingIdeaService");
        TrafficEstimatorService =
            AdWordsService.MakeServiceSignature("v201008", "o", "TrafficEstimatorService");
        UserListService =
            AdWordsService.MakeServiceSignature("v201008", "cm", "UserListService");
      }
    }
  }
}