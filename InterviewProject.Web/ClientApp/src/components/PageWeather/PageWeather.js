import React, {useEffect} from 'react';
import SearchForm from '../SearchForm';
import Loader from '../Loader';
import Forecast from '../Forecast';
import useForecast from '../../../hooks/useForecast';
import styles from './PageWeather.module.css';

export default function PageWeather()  {
    const {
        isError, isLoading, forecast, submitSearch,
    } = useForecast();
    const onSubmit = (value) => {
        submitSearch(value);
    };
    useEffect(() => {
        console.log('Forecast', forecast);
    }, [forecast])
    return (
        <>
            {!forecast && (
                <div className={`${styles.box} position-relative`}>
                    {!isLoading && <SearchForm submitSearch={onSubmit} />}
                    {isLoading && <Loader />}
                </div>
            )}
            {forecast && <Forecast forecast={forecast} />}
        </>
    );
};