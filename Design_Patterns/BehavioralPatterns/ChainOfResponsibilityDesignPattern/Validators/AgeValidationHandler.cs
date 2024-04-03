namespace ChainOfResponsibilityDesignPattern.Validators
{
    public class AgeValidationHandler : Handler<UserDto>, IHandler<UserDto>
    {
        public override void Handle(UserDto entity)
        {
            if (entity.Age < 18)
                throw new Exception("only 18+ ages people can register fromm this website");
            base.Handle(entity);
        }
    }
}
