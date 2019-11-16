using Algebra.Application.DTOs;
using Microsoft.Extensions.Options;

namespace Algebra.Application.Descriptors
{
    public class DescriptorsService : IDescriptorsService
    {
        private readonly ApiStateOptions apiStateOptions;
        public DescriptorsService(IOptions<ApiStateOptions> apiStateOptions)
        {
            this.apiStateOptions = apiStateOptions.Value;
        }
        public ApiDescriptorDTO GetDescriptor() =>
            new ApiDescriptorDTO { ApiDevelomentStage = apiStateOptions.State };
        
    }
}
