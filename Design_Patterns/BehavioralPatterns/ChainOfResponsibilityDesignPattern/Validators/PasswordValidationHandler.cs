namespace ChainOfResponsibilityDesignPattern.Validators
{
    public class PasswordValidationHandler : Handler<UserDto>, IHandler<UserDto>
    {
        public override void Handle(UserDto entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Password))
                throw new Exception("password cannot be empty.");
            else if (entity.Password.Length < 8)
                throw new Exception("password length should be at least 8 characters.");
            base.Handle(entity);
        }
    }
}
