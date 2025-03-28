﻿namespace TCSA.V2026.Data.Models.LanguageModels;

public record DutchHeadings : ILanguageHeadings
{
    public string Introduction => "Inleiding";
    public string Requirements => "Vereisten";
    public string Learn => "Leren";
    public string Resources => "Hulpbronnen";
    public string Tips => "Wat je gaat leren";
    public string Challenges => "Uitdagingen";
    public string RoadmapStepCompleted => "Je hebt deze stap voltooid.";
    public string PendingReview => "Dit project wacht op beoordeling";
    public string ReviewRepository => "github-repository";
}
