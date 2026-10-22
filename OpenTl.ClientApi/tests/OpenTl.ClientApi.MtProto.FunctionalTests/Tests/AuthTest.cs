namespace OpenTl.ClientApi.MtProto.FunctionalTests.Tests
{
    using System.Threading;
    using System.Threading.Tasks;

    using OpenTl.ClientApi.MtProto.FunctionalTests.Framework;
    using OpenTl.Schema.Auth;

    using Xunit;
    using Xunit.Abstractions;

    public sealed class AuthTest : FunctionalTest
    {
        public AuthTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public async Task TryAuthWithMigration()
        {
            var settings = Container.Resolve<IClientSettings>();

            const string PhoneNumber = "REPLACE_WITH_YOUR_VALUE";
            const string PhoneCode = "REPLACE_WITH_YOUR_VALUE";

            var requestSendCode = new RequestSendCode
                                  {
                                      PhoneNumber = PhoneNumber,
                                      ApiId = settings.AppId,
                                      ApiHash = settings.AppHash
                                  };

            var sentCode = (TSentCode)await RequestSender.SendRequestAsync(requestSendCode, CancellationToken.None).ConfigureAwait(false);

            var requestSignIn = new RequestSignIn
                                {
                                    PhoneNumber = PhoneNumber,
                                    PhoneCodeHash = sentCode.PhoneCodeHash,
                                    PhoneCode = PhoneCode
                                };

            var result = (TAuthorization)await RequestSender.SendRequestAsync(requestSignIn, CancellationToken.None).ConfigureAwait(false);
        }

        [Fact]
        public async Task TryAuthWithoutMigration()
        {
            var settings = Container.Resolve<IClientSettings>();

            const string PhoneNumber = "REPLACE_WITH_YOUR_VALUE";
            const string PhoneCode = "REPLACE_WITH_YOUR_VALUE";

            var requestSendCode = new RequestSendCode
                                  {
                                      PhoneNumber = PhoneNumber,
                                      ApiId = settings.AppId,
                                      ApiHash = settings.AppHash
                                  };

            var sentCode = (TSentCode)await RequestSender.SendRequestAsync(requestSendCode, CancellationToken.None).ConfigureAwait(false);

            var requestSignIn = new RequestSignIn
                                {
                                    PhoneNumber = PhoneNumber,
                                    PhoneCodeHash = sentCode.PhoneCodeHash,
                                    PhoneCode = PhoneCode
                                };

            var result = (TAuthorization)await RequestSender.SendRequestAsync(requestSignIn, CancellationToken.None).ConfigureAwait(false);
        }
    }
}