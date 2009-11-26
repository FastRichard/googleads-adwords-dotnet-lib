// Copyright 2009, Google Inc. All Rights Reserved.
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

using com.google.api.adwords.lib;
using com.google.api.adwords.v200909;

using System;

namespace com.google.api.adwords.samples.v200909 {
  /// <summary>
  /// This code sample retrieves all the disapproved ads in a given campaign.
  /// </summary>
  class GetAllDisapprovedAds : SampleBase {
    /// <summary>
    /// Returns a description about the sample code.
    /// </summary>
    public override string Description {
      get {
        return "This code sample retrieves all the disapproved ads in a given campaign.";
      }
    }

    /// <summary>
    /// Run the sample code.
    /// </summary>
    /// <param name="user">The AdWords user object running the sample.
    /// </param>
    public override void Run(AdWordsUser user) {
      AdGroupAdService service =
          (AdGroupAdService) user.GetService(AdWordsService.v200909.AdGroupAdService);

      // Create a selector and set the filters.
      AdGroupAdSelector selector = new AdGroupAdSelector();
      selector.campaignIds = new long[] {long.Parse(_T("INSERT_CAMPAIGN_ID_HERE"))};

      try {
        AdGroupAdPage page = service.get(selector);

        if (page != null && page.entries != null) {
          foreach (AdGroupAd tempAdGroupAd in page.entries) {
            if (tempAdGroupAd.ad.approvalStatus == AdApprovalStatus.DISAPPROVED) {
              Console.WriteLine("Ad id {0} has been disapproved for the following reason(s):",
                  tempAdGroupAd.ad.id);
              foreach (string reason in tempAdGroupAd.ad.disapprovalReasons) {
                Console.WriteLine("    {0}", reason);
              }
            }
          }
        }
      } catch (Exception ex) {
        Console.WriteLine("Failed to create Ad(s). Exception says \"{0}\"", ex.Message);
      }
    }
  }
}