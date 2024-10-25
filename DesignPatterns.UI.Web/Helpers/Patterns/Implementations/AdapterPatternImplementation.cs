using DesignPatterns.AdapterPattern.Models;
using DesignPatterns.UI.Web.Helpers.Patterns.Interfaces;
using DesignPatterns.UI.Web.Models.Result;
using System.Text.Json;

namespace DesignPatterns.UI.Web.Helpers.Patterns.Implementations
{
    public class AdapterPatternImplementation : IPatternHelperImplementation
    {
        public string ExecutePatternImplementation(string inputData)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IgnoreNullValues = true
            };

            var designPatternData = JsonSerializer.Deserialize<PolicyFeeInputData>(inputData, options);
            var policyFee = new PolicyFee
            {
                Fee = designPatternData.Fee,
                PolicyHolderName = designPatternData.PolicyHolderName,
                PolicyType = designPatternData.PolicyType
            };

            var policyFeeAdapter = new PolicyFeeAdapter(policyFee);
            policyFeeAdapter.FamilyMembers = designPatternData.FamilyMembers;

            var outcomeModel = new List<ResultModel>();

            outcomeModel.Add(new ResultModel
            {
                Heading = "Policy",
                ResultProperties = new Dictionary<string, string>
                {
                    { "Policy Holder", policyFee.PolicyHolderName },
                    { "Policy Type", policyFee.PolicyType },
                    { "Policy Fee", policyFee.Fee.ToString() },
                },
            });

            outcomeModel.Add(new ResultModel
            {
                Heading = "Family Policy",
                ResultProperties = new Dictionary<string, string>
                {
                    { "Policy Holder", policyFeeAdapter.PolicyHolderName },
                    { "Policy Type", policyFeeAdapter.PolicyType },
                    { "Policy Fee", policyFeeAdapter.Fee.ToString() },
                    //{ "Policy Fee", policyFee.Fee.ToString() },
                    { "-- Base Fee", policyFeeAdapter.BaseFee.ToString() },
                    { "-- Family Members", policyFeeAdapter.FamilyMembers.ToString() },
                    { "-- Discount", policyFeeAdapter.PolicyFeeDiscount.ToString() + "%" },
                    { "-- Discount Value", policyFeeAdapter.PolicyFeeDiscountValue.ToString() }
                },
            });

            return JsonSerializer.Serialize(outcomeModel);
        }
    }
}
