using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class RetrieveTokenController : ApiController
    {
        public TokenResponse Get()
        {
            TokenResponse tokenRes = new TokenResponse();
            tokenRes.Token = "eyJlbmMiOiJBMTI4R0NNIiwiYWxnIjoiUlNBLU9BRVAtMjU2In0.VLdesg4xOFwEnrHNRcX1k-xhcZ7LJEE6w8S5PcXHK3HEdn3NMowJiwx8IC3o7qj-rOhgRaYgo62kfTtZPShbCnikS3zVYNLT5nz-ZZJGgb1CQiDipy-Zq0bPIjKGG6nbBB0SpJoATtpSGYKUlHZZMPsOtyB2X4OmGYGzFjn_po0GbfAxINMH6w9wSm6CtP7T5h87tpR4xZz3doXnpe4wVBCWygJYGLbUITPMLLc5x7dhF-aLClDfHa1qLKjlqVIFdedwNDhqjivwQMJgbJTnY6Rk3IPnEwBdmotRrtaYmYHE5i6FxDDmsEGKiFiIJA-3jK6INkOCVSME9c_IqdI-ag.AgLo9EeYPz7op7Nb.cGWuOiEY0Ry0Ri9uJUTAsDjER99vcVikwcURdQpBaB_aRPv1Wc6-aGDHZNwFhoevQ9WIcxaYKmMlhTmYDchSSgN5Xc4cOOicNf2sfbGvaQGfPudBMNdgZBZS1ECgLrad8LcN8oL1AGYNv3mW9OLFDa13KJt1vxCK915uxrNQoNhFBLxF5RtrtCW2kPdMeVI357bPxU58-eE1VIpz7OzduUIdGKm3eOnVmH_PZPEQyI_9LiDEWmSPkIYl3qf_v8Ct0ifPZY5EvyRxYBQEx7_0DbAS.3SXacicYRopSA1P1k0bEJA";

            return tokenRes;
        }
    }
}
