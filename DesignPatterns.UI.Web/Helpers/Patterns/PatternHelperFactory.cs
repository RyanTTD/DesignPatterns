using DesignPatterns.UI.Web.Helpers.Patterns.Implementations;
using DesignPatterns.UI.Web.Helpers.Patterns.Interfaces;
using DesignPatterns.UI.Web.Models.Enums;
using DesignPatterns.UI.Web.Models.Request;

namespace DesignPatterns.UI.Web.Helpers.Patterns
{
    public class PatternHelperFactory
    {
        public IPatternHelperImplementation GetFactoryClass(RequestModel model)
        {
            IPatternHelperImplementation result = null;

            switch (model.RequestTypeId)
            {
                case (int)PatternTypeEnum.AdapterPattern:
                    {
                        result = new AdapterPatternImplementation();
                        break;
                    }
            }

            return result;
        }
    }
}
