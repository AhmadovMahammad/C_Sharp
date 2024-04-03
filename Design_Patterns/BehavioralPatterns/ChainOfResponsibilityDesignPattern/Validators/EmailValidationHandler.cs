using System.Text.RegularExpressions;

namespace ChainOfResponsibilityDesignPattern.Validators
{
    public class EmailValidationHandler : Handler<UserDto>, IHandler<UserDto>
    {
        public override void Handle(UserDto entity)
        {
            if (!Regex.IsMatch(entity.Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                throw new Exception("invalid email format.");

            base.Handle(entity);
        }
    }
}
