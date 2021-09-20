package io.mathreis.nbadashboard.data;

import java.time.LocalDateTime;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import org.springframework.batch.item.ItemProcessor;

public class MatchDataProcessor implements ItemProcessor<MatchInput, Match> {

    private static final Logger log = LoggerFactory.getLogger(MatchDataProcessor.class);

    @Override
    public Match process(final MatchInput matchInput) throws Exception {

        Match match = new Match();
        match.setGameId(matchInput.getGameId());
        match.setTeamNameHome(matchInput.getTeamNameHome());
        match.setGameDat(LocalDateTime.parse(matchInput.getGameDate()));         
        match.setWlHome(matchInput.getWlHome());
        match.setPtsHome(Integer.parseInteger(matchInput.getPtsHome()));
        match.setTeamNameAway(matchInput.getTeamNameAway());
        match.setWlAway(matchInput.getWlAway());
        match.setPtsAway(Integer.parseInteger(matchInput.getPtsAway()));
        match.setSeason(matchInput.getSeason());
        match.setAttendance(matchInput.getAttendance());
        match.setTeamCityNameHome(matchInput.getTeamCityNameHome());
        match.setTeamNicknameHome(matchInput.getTeamNicknameHome());
        match.setTeamCityNameAway(matchInput.getTeamCityNameAway());
        match.setTeamNicknameAway(matchInput.getTeamNicknameAway());





        return match;
    }
}
