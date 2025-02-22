// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Options;
global using System.Security.Claims;
global using Microsoft.AspNetCore.Components.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using CleanArchitecture.Blazor.Domain;
global using CleanArchitecture.Blazor.Domain.Common;
global using CleanArchitecture.Blazor.Domain.Entities;
global using CleanArchitecture.Blazor.Domain.Entities.Audit;
global using CleanArchitecture.Blazor.Domain.Entities.Log;
global using CleanArchitecture.Blazor.Infrastructure.Persistence.Extensions;
global using CleanArchitecture.Blazor.Application.Common.Exceptions;
global using CleanArchitecture.Blazor.Application.Common.Models;
global using CleanArchitecture.Blazor.Application.Common.Interfaces;
global using CleanArchitecture.Blazor.Application.Common.Interfaces.Identity;
global using CleanArchitecture.Blazor.Application.Settings;
global using CleanArchitecture.Blazor.Application.Configurations;
global using CleanArchitecture.Blazor.Infrastructure.Constants;
global using CleanArchitecture.Blazor.Application.Constants;
global using CleanArchitecture.Blazor.Domain.Identity;
global using CleanArchitecture.Blazor.Infrastructure.Middlewares;
global using CleanArchitecture.Blazor.Infrastructure.Persistence;
global using CleanArchitecture.Blazor.Infrastructure.Services;
global using CleanArchitecture.Blazor.Infrastructure.Services.Identity;
