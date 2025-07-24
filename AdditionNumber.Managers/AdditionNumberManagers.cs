using AdditionNumber.Models;

namespace AdditionNumber.Managers
{
    public class AdditionNumberManagers
    {
        public AdditionNumberResultModel Add(AdditionNumberModel input)
        {
            int value = input.Number1 + input.Number2;
            return new AdditionNumberResultModel()
            {
               Result = value
            };
        }
    }
}
