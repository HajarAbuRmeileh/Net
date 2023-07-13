using System;
using System.Collections.Generic;

namespace Chatbot.Models;

public partial class Package
{
    public int Id { get; set; }

    public string LogisticsInterface { get; set; } = null!;

    public string DataDigest { get; set; } = null!;

    public string PartnerCode { get; set; } = null!;

    public string FromCode { get; set; } = null!;

    public string MsgType { get; set; } = null!;

    public string MsgId { get; set; } = null!;
}
