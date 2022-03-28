import React from 'react';
import styles from './CurrentDay.module.css';

export default function CurrentDay ({currentDay}) {
    console.log('Currentday', currentDay)
    const {
        weekday, date, location, temperature, weatherIcon, weatherDescription,
    } = currentDay;

    return (
        <div className="d-flex parentContainer">
            <div className={styles.img}/>
            <div className={styles.gradient}/>
            <div className={`${styles.cardInner} d-flex flex-column justify-content-between pt-3 pb-2 pl-2`}>
                <div>
                    <h2 className="font-weight-bold mb-1">{weekday}</h2>
                    <p className="mb-0">{date}</p>
                    <p className="d-flex align-items-baseline font-weight-lighter mb-1">
                        <span>{location}</span>
                    </p>
                </div>
                <div>
                    <img width="45" src={weatherIcon} alt=""/>
                    <h2 className="font-weight-bold mb-1">
                        <span>{temperature}</span>
                        °C
                    </h2>
                    <h5 className="font-weight-lighter">{weatherDescription}</h5>
                </div>
            </div>
        </div>
    );
}