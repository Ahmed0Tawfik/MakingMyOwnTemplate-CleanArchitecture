﻿namespace YourProjectName.Application.Services.Authentication
{
    public record AuthenticationResponse
        (
            Guid Id,
            string Email,
            string Token
        );

}
