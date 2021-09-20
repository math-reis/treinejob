package io.mathreis.nbadashboard.model;

import java.time.LocalDate;

public class Match {
    
    private String gameId;
    private String teamNameHome;
    private LocalDate gameDate;
    private String wlHome;
    private Integer ptsHome;
    private String teamNameAway;
    private String wlAway;
    private Integer ptsAway;
    private String season;
    private String attendance;
    private String teamCityNameHome;
    private String teamNicknameHome;
    private String teamCityNameAway;
    private String teamNicknameAway;
    
    public String getGameId() {
        return gameId;
    }
    public void setGameId(String gameId) {
        this.gameId = gameId;
    }
    public String getTeamNameHome() {
        return teamNameHome;
    }
    public void setTeamNameHome(String teamNameHome) {
        this.teamNameHome = teamNameHome;
    }
    public LocalDate getGameDate() {
        return gameDate;
    }
    public void setGameDate(LocalDate gameDate) {
        this.gameDate = gameDate;
    }
    public String getWlHome() {
        return wlHome;
    }
    public void setWlHome(String wlHome) {
        this.wlHome = wlHome;
    }
    public Integer getPtsHome() {
        return ptsHome;
    }
    public void setPtsHome(Integer ptsHome) {
        this.ptsHome = ptsHome;
    }
    public String getTeamNameAway() {
        return teamNameAway;
    }
    public void setTeamNameAway(String teamNameAway) {
        this.teamNameAway = teamNameAway;
    }
    public String getWlAway() {
        return wlAway;
    }
    public void setWlAway(String wlAway) {
        this.wlAway = wlAway;
    }
    public Integer getPtsAway() {
        return ptsAway;
    }
    public void setPtsAway(Integer ptsAway) {
        this.ptsAway = ptsAway;
    }
    public String getSeason() {
        return season;
    }
    public void setSeason(String season) {
        this.season = season;
    }
    public String getAttendance() {
        return attendance;
    }
    public void setAttendance(String attendance) {
        this.attendance = attendance;
    }
    public String getTeamCityNameHome() {
        return teamCityNameHome;
    }
    public void setTeamCityNameHome(String teamCityNameHome) {
        this.teamCityNameHome = teamCityNameHome;
    }
    public String getTeamNicknameHome() {
        return teamNicknameHome;
    }
    public void setTeamNicknameHome(String teamNicknameHome) {
        this.teamNicknameHome = teamNicknameHome;
    }
    public String getTeamCityNameAway() {
        return teamCityNameAway;
    }
    public void setTeamCityNameAway(String teamCityNameAway) {
        this.teamCityNameAway = teamCityNameAway;
    }
    public String getTeamNicknameAway() {
        return teamNicknameAway;
    }
    public void setTeamNicknameAway(String teamNicknameAway) {
        this.teamNicknameAway = teamNicknameAway;
    }


    
}
