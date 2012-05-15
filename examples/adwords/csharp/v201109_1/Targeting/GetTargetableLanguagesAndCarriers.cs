// Copyright 2012, Google Inc. All Rights Reserved.
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

using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.AdWords.v201109_1;

using System;
using System.Collections.Generic;
using System.IO;

namespace Google.Api.Ads.AdWords.Examples.CSharp.v201109_1 {
  /// <summary>
  /// This code example illustrates how to retrieve all carriers and languages
  /// available for targeting.
  ///
  /// Tags: ConstantDataService.getCarrierCriterion
  /// Tags: ConstantDataService.getLanguageCriterion
  /// </summary>
  public class GetTargetableLanguagesAndCarriers : ExampleBase {
    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      ExampleBase codeExample = new GetTargetableLanguagesAndCarriers();
      Console.WriteLine(codeExample.Description);
      try {
        codeExample.Run(new AdWordsUser(), codeExample.GetParameters(), Console.Out);
      } catch (Exception ex) {
        Console.WriteLine("An exception occurred while running this code example. {0}",
            ExampleUtilities.FormatException(ex));
      }
    }

    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This code example illustrates how to retrieve all carriers and languages " +
            "available for targeting.";
      }
    }

    /// <summary>
    /// Gets the list of parameter names required to run this code example.
    /// </summary>
    /// <returns>
    /// A list of parameter names for this code example.
    /// </returns>
    public override string[] GetParameterNames() {
      return new string[] {};
    }

    /// <summary>
    /// Runs the code example.
    /// </summary>
    /// <param name="user">The AdWords user.</param>
    /// <param name="parameters">The parameters for running the code
    /// example.</param>
    /// <param name="writer">The stream writer to which script output should be
    /// written.</param>
    public override void Run(AdWordsUser user, Dictionary<string, string> parameters,
        TextWriter writer) {
      // Get the ConstantDataService.
      ConstantDataService constantDataService = (ConstantDataService) user.GetService(
          AdWordsService.v201109_1.ConstantDataService);

      try {
        // Get all carriers.
        Carrier[] carriers = constantDataService.getCarrierCriterion();

        // Display the results.
        if (carriers != null) {
          foreach (Carrier carrier in carriers) {
            writer.WriteLine("Carrier name is '{0}', ID is {1} and country code is '{2}'.",
                carrier.name, carrier.id, carrier.countryCode);
          }
        } else {
          writer.WriteLine("No carriers were retrieved.");
        }

        // Get all languages.
        Language[] languages = constantDataService.getLanguageCriterion();

        // Display the results.
        if (languages != null) {
          foreach (Language language in languages) {
            writer.WriteLine("Language name is '{0}', ID is {1} and code is '{2}'.",
                language.name, language.id, language.code);
          }
        } else {
          writer.WriteLine("No languages were found.");
        }
      } catch (Exception ex) {
        throw new System.ApplicationException("Failed to get targetable carriers and languages.",
            ex);
      }
    }
  }
}