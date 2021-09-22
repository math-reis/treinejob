package io.mathreis.nbadashboard.data;

import javax.sql.DataSource;

import org.springframework.batch.core.configuration.annotation.EnableBatchProcessing;
import org.springframework.batch.core.configuration.annotation.JobBuilderFactory;
import org.springframework.batch.core.configuration.annotation.StepBuilderFactory;
import org.springframework.batch.item.database.BeanPropertyItemSqlParameterSourceProvider;
import org.springframework.batch.item.database.JdbcBatchItemWriter;
import org.springframework.batch.item.database.builder.JdbcBatchItemWriterBuilder;
import org.springframework.batch.item.file.FlatFileItemReader;
import org.springframework.batch.item.file.builder.FlatFileItemReaderBuilder;
import org.springframework.batch.item.file.mapping.BeanWrapperFieldSetMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.io.ClassPathResource;

@Configuration
@EnableBatchProcessing
public class BatchConfig {

    private final String[] FIELD_NAMES = new String[] { "GAME_ID", "TEAM_NAME_HOME", "GAME_DATE", "WL_HOME", "PTS_HOME",
            "TEAM_NAME_AWAY", "WL_AWAY", "PTS_AWAY", "SEASON", "ATTENDANCE", "TEAM_CITY_NAME_HOME",
            "TEAM_NICKNAME_HOME", "TEAM_CITY_NAME_AWAY", "TEAM_NICKNAME_AWAY" };

    @Autowired
    public JobBuilderFactory jobBuilderFactory;

    @Autowired
    public StepBuilderFactory stepBuilderFactory;

    @Bean
    public FlatFileItemReader<MatchInput> reader() {
        return new FlatFileItemReaderBuilder<MatchInput>().name("MatchItemReader")
                .resource(new ClassPathResource("match-data.csv")).delimited().names(FIELD_NAMES)
                .fieldSetMapper(new BeanWrapperFieldSetMapper<MatchInput>() {
                    {
                        setTargetType(MatchInput.class);
                    }
                }).build();
    }

    @Bean
    public MMatchDataProcessor processor() {
        return new MatchDataProcessor();
    }

    @Bean
    public JdbcBatchItemWriter<Match> writer(DataSource dataSource) {
        return new JdbcBatchItemWriterBuilder<Match>()
                .itemSqlParameterSourceProvider(new BeanPropertyItemSqlParameterSourceProvider<>())
                .sql("INSERT INTO match (game_id, team_name_home, game_date, wl_home, pts_home, team_name_away, wl_away, pts_away, season, attendance, team_city_name_home, team_nickname_home, team_city_name_away, team_nickname_away) "
                        + " VALUES (:gameId, :teamNameHome, :gameDate, :wlHome, :ptsHome, :teamNameAway, :wlAway, :ptsAway, :season, :attendance, :teamCityNameHome, :teamNicknameHome, :teamCityNameAway, :teamNicknameAway)")
                .dataSource(dataSource).build();
    }
}