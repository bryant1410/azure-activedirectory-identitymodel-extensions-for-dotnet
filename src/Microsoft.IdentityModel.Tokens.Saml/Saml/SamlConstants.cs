//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

namespace Microsoft.IdentityModel.Tokens.Saml
{
    public static class SamlConstants
    {
        public const int MajorVersionValue = 1;
        public const int MinorVersionValue = 1;
        public const string Namespace = "urn:oasis:names:tc:SAML:1.0:assertion";
        public const string NamespaceAttributePrefix = "NamespaceAttributePrefix";
        public const string PreferredPrefix = "saml";
        public const string Saml11Namespace = "urn:oasis:names:tc:SAML:1.0:assertion";
        public const string Saml2Namespace = "urn:oasis:names:tc:SAML:2.0:assertion";
        public const string SenderVouches = "urn:oasis:names:tc:SAML:1.0:cm:sender-vouches";
        public const string Statement = "Statement";
        public const string SubjectStatement = "SubjectStatement";
        public const string UserName = "UserName";
        public const string UserNameNamespace = "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName";
        public const string UnspecifiedAuthenticationMethod = "urn:oasis:names:tc:SAML:1.0:am:unspecified";

        public static string[] AcceptedDateTimeFormats = new string[] {
                "yyyy-MM-ddTHH:mm:ss.fffffffZ",
                "yyyy-MM-ddTHH:mm:ss.ffffffZ",
                "yyyy-MM-ddTHH:mm:ss.fffffZ",
                "yyyy-MM-ddTHH:mm:ss.ffffZ",
                "yyyy-MM-ddTHH:mm:ss.fffZ",
                "yyyy-MM-ddTHH:mm:ss.ffZ",
                "yyyy-MM-ddTHH:mm:ss.fZ",
                "yyyy-MM-ddTHH:mm:ssZ",
                "yyyy-MM-ddTHH:mm:ss.fffffffzzz",
                "yyyy-MM-ddTHH:mm:ss.ffffffzzz",
                "yyyy-MM-ddTHH:mm:ss.fffffzzz",
                "yyyy-MM-ddTHH:mm:ss.ffffzzz",
                "yyyy-MM-ddTHH:mm:ss.fffzzz",
                "yyyy-MM-ddTHH:mm:ss.ffzzz",
                "yyyy-MM-ddTHH:mm:ss.fzzz",
                "yyyy-MM-ddTHH:mm:sszzz" };

        public const string AssertionIdPrefix = "SamlSecurityToken-";
        public const string GeneratedDateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffZ";

        internal static class Attributes
        {
            public const string ActionNamespaceAttribute = "Namespace";
            public const string AssertionId = "AssertionID";
            public const string AttributeName = "AttributeName";
            public const string AttributeNamespace = "AttributeNamespace";
            public const string AuthenticationInstant = "AuthenticationInstant";
            public const string AuthenticationMethod = "AuthenticationMethod";
            public const string AuthorityBinding = "AuthorityBinding";
            public const string AuthorityKind = "AuthorityKind";
            public const string Binding = "Binding";
            public const string Decision = "Decision";
            public const string Issuer = "Issuer";
            public const string IssueInstant = "IssueInstant";
            public const string Location = "Location";
            public const string MajorVersion = "MajorVersion";
            public const string MinorVersion = "MinorVersion";
            public const string OriginalIssuer = "OriginalIssuer";
            public const string NamespaceAttributePrefix = "xmlns";
            public const string NameIdentifierFormat = "Format";
            public const string NameIdentifierNameQualifier = "NameQualifier";
            public const string Namespace = "Namespace";
            public const string NotBefore = "NotBefore";
            public const string NotOnOrAfter = "NotOnOrAfter";
            public const string Resource = "Resource";
            public const string SubjectLocalityDNSAddress = "DNSAddress";
            public const string SubjectLocalityIPAddress = "IPAddress";
        }

        /// <summary>
        /// Known values for <see cref="Microsoft.IdentityModel.Tokens.SamlAuthenticationStatement"/>
        /// </summary>
        public static class AuthenticationMethods
        {
            public const string HardwareTokenString = "URI:urn:oasis:names:tc:SAML:1.0:am:HardwareToken";
            public const string KerberosString = "urn:ietf:rfc:1510";
            public const string PasswordString = "urn:oasis:names:tc:SAML:1.0:am:password";
            public const string PgpString = "urn:oasis:names:tc:SAML:1.0:am:PGP";
            public const string SecureRemotePasswordString = "urn:ietf:rfc:2945";
            public const string SignatureString = "urn:ietf:rfc:3075";
            public const string SpkiString = "urn:oasis:names:tc:SAML:1.0:am:SPKI";
            public const string TlsClientString = "urn:ietf:rfc:2246";
            public const string UnspecifiedString = "urn:oasis:names:tc:SAML:1.0:am:unspecified";
            public const string WindowsString = "urn:federation:authentication:windows";
            public const string X509String = "urn:oasis:names:tc:SAML:1.0:am:X509-PKI";
            public const string XkmsString = "urn:oasis:names:tc:SAML:1.0:am:XKMS";
        }

        internal static class Elements
        {
            public const string Action = "Action";
            public const string Advice = "Advice";
            public const string Assertion = "Assertion";
            public const string AssertionIdReference = "AssertionIDReference";
            public const string Attribute = "Attribute";
            public const string AttributeStatement = "AttributeStatement";
            public const string AttributeValue = "AttributeValue";
            public const string Audience = "Audience";
            public const string AudienceRestrictionCondition = "AudienceRestrictionCondition";
            public const string AuthenticationStatement = "AuthenticationStatement";
            public const string AuthorityBinding = "AuthorityBinding";
            public const string AuthorizationDecisionStatement = "AuthorizationDecisionStatement";
            public const string Conditions = "Conditions";
            public const string DoNotCacheCondition = "DoNotCacheCondition";
            public const string Evidence = "Evidence";
            public const string NameIdentifier = "NameIdentifier";
            public const string SubjectConfirmation = "SubjectConfirmation";
            public const string Subject = "Subject";
            public const string SubjectConfirmationData = "SubjectConfirmationData";
            public const string SubjectConfirmationMethod = "ConfirmationMethod";
            public const string SubjectLocality = "SubjectLocality";
            public const string SubjectLocalityDNSAddress = "DNSAddress";
            public const string SubjectLocalityIPAddress = "IPAddress";

        }


    }
}