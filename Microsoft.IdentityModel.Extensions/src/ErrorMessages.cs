﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
namespace Microsoft.IdentityModel.Extensions
{
    /// <summary>
    /// Error codes and messages
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    public static class ErrorMessages
    {
        // general messages 10000 - 10099
        public const string IDX10000 = "IDX10000: The parameter '{0}' cannot be a 'null' or an empty string.";
        public const string IDX20000 = "IDX20000: The property value '{0}' cannot be a 'null' or an empty string.";
        public const string IDX30000 = "IDX30000: The parameter '{0}' cannot be 'null' or a string containing only whitespace.";

        // messages pertaining to setting protperties, configuration 
        public const string IDX10100 = "IDX10100: MaximumTokenSizeInBytes must be greater than zero. value: '{0}'";

        // messages pertaining to validation 10200 - 10299
        public const string IDX10200 = "IDX10200: Support for ValidateToken(string, TokenValidationParameters) requires a handler to implement ISecurityTokenValidator, none of the SecurityTokenHandlers did.";
        public const string IDX10201 = "IDX10201: None of the the SecurityTokenHandlers could read the 'securityToken': '{0}'.";
        public const string IDX10202 = "IDX10202: Saml2Token.Assertion is null, can not create an identity.";
        public const string IDX10203 = "IDX10203: Saml2.Assertion.Issuer is null or whitespace.";
        public const string IDX10204 = "IDX10204: Unable to validate issuer. validationParameters.ValidIssuer is null or whitespace AND validationParameters.ValidIssuers is null.";
        public const string IDX10205 = "IDX10205: Unable to validate issuer, validationParameters.ValidIssuer: '{0}' or validationParameters.ValidIssuers: '{1}' did not match Issuer: '{2}'. Comparison is: Equals ";
        public const string IDX10206 = "IDX10206: Unable to validate issuer, 'securityToken' type was not a: '{0}', was a: '{1}'";
        public const string IDX10207 = "IDX10207: Unable to validate audience, the Saml2 token did not contain any audiences.";
        public const string IDX10208 = "IDX10208: Unable to validate audience. validationParameters.AllowedAudience is null or whitespace and validationParameters.AllowedAudiences is null.";
    }
}