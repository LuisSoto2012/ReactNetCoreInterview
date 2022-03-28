import React from 'react';
import { Container, Row, Col } from 'react-bootstrap';

import CurrentDay from '../CurrentDay';
import CurrentDayDescription from '../CurrentDayDescription';
import UpcomingDaysForecast from '../UpcomingDaysForecast';
import styles from './Forecast.module.css';

export default function Forecast ({forecast}) {
    const {currentDay} = forecast;
    return(
        <Container>
            <Row>
                <Col xs={12} md={4}>
                    <div>
                        <CurrentDay currentDay={currentDay} />
                    </div>
                </Col>
                <Col xs={12} md={8} className="d-flex flex-column justify-content-between">
                    <CurrentDayDescription forecast={forecast.currentDayDetails} />
                    <UpcomingDaysForecast days={forecast.upcomingDays} />
                </Col>
            </Row>
        </Container>
    )
}