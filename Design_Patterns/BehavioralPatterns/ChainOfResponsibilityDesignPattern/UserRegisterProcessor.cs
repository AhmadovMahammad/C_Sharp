using ChainOfResponsibilityDesignPattern.Validators;

namespace ChainOfResponsibilityDesignPattern
{
    public class UserRegisterProcessor
    {
        public bool Register(UserDto user)
        {
            var initialHandler = new EmailValidationHandler();
            initialHandler.SetNextHandler(new PasswordValidationHandler())
                .SetNextHandler(new AgeValidationHandler());
            try
            {
                initialHandler.Handle(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error message : {ex.Message}");
                return false;
            }
            return true;
        }
    }
}
