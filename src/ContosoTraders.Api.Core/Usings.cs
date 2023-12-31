﻿global using AutoMapper;
global using FluentValidation;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
global using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
global using Microsoft.Extensions.Configuration;
global using ContosoTraders.Api.Core;
global using ContosoTraders.Api.Core.Constants;
global using ContosoTraders.Api.Core.Exceptions;
global using ContosoTraders.Api.Core.Models;
global using ContosoTraders.Api.Core.Models.Implementations.Dao;
global using ContosoTraders.Api.Core.Models.Implementations.Dto;
global using ContosoTraders.Api.Core.Models.Interfaces;
global using ContosoTraders.Api.Core.Repositories;
global using ContosoTraders.Api.Core.Repositories.Implementations;
global using ContosoTraders.Api.Core.Repositories.Interfaces;
global using ContosoTraders.Api.Core.Requests.Definitions;
global using ContosoTraders.Api.Core.Requests.Validators;
global using ContosoTraders.Api.Core.Services.Implementations;
global using ContosoTraders.Api.Core.Services.Interfaces;