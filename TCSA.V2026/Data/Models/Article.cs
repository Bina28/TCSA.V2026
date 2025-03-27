﻿namespace TCSA.V2026.Data.Models;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }
    public string BannerUrl { get; set; }
    public string BannerV2 { get; set; }
    public Area Area { get; set; }
    public List<Block> Blocks { get; set; }
    public DateTime ReleaseDate { get; set; } // TODO move this to project
    public int ExperiencePoints { get; set; }
    public Level Level { get; set; }
    public bool IsClosed { get; set; }
    public string NextSlug { get; set; }
    public string CardImgUrl { get; set; }
    public string Author { get; set; }
    public string? Url { get; set; }
    public int? CourseDisplayId {  get; set; }
}

public class Block
{
    public bool IsCourseCodePage {  get; set; }
    public string? Title { get; set; }
    public string? ImgUrl { get; set; }
    public string? BookImgUrl { get; set; }
    public List<Paragraph> Paragraphs { get; set; }
}

public class Paragraph
{
    public string? FontColor { get; set; }  
    public string? BackgroundColor { get; set; }
    public bool IsPicture { get; set; } = false;
    public bool IsVideo { get; set; } = false;
    public bool IsCode { get; set; } = false;
    public string? PictureUrl { get; set; }
    public string? VideoUrl { get; set; }
    public string? Body { get; set; }
}

public enum Area
{
    HowItWorks,
    StartHere,
    Console,
    StartApplying,
    MVC,
    Angular,
    React,
    Blazor,
    MAUI,
    Azure,
    FullStack,
    StandAlone,
    OpenSource,
    MonthlyChallenge,
    SQL,
    Auth,
    GraduationProject,
    FreestyleProject,
    Blog, 
    Principles, 
    Course
}

