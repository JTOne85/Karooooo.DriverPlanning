using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Presentation.Contracts;

public sealed record GetAllDriversRequest
{
    public string? Search { get; init; }
    public int Page { get; init; }
    public int PageSize { get; init; }
}
