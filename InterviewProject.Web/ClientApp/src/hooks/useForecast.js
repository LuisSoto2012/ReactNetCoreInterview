import { useState, useEffect } from 'react';
import getCurrentDayForecast from '../helpers/getCurrentDayForecast';
import getCurrentDayDetailsForecast from '../helpers/getCurrentDayDetailsForecast';
import getUpcomingDaysForecast from '../helpers/getUpcomingDaysForecast';

export default function useForecast () {
    const [isError, setError] = useState(false);
    const [isLoading, setLoading] = useState(false);
    const [forecast, setForecast] = useState(null);
    
    const getWoeid = async (location) => {
        const response  = await fetch(`api/weatherforecast/getwoeid?location=${location}`);
        const data = await response.json();
        if (!data || data.length === 0) {
            setError('Location not found.');
            setLoading(false);
            return {};
        }
    
        return data[0];
    };
    
    const getForecastData = async (woeid) => {
        console.log('Enter Get Forecast Data')
        const response = await fetch(`api/weatherforecast/${woeid}`);
        const data = await response.json();
        console.log(data)
        if (!data || data.length === 0) {
            setError('Something went wrong. Please try again!');
            setLoading(false);
            return {};
        }
        //return data.consolidated_weather.length > 5 ? data.consolidated_weather.slice(0, 5) : data.consolidated_weather;
        return data;
    };
    
    const gatherForecastData = (data) => {
        const currentDay = getCurrentDayForecast(data.consolidated_weather[0], data.title);
        const currentDayDetails = getCurrentDayDetailsForecast(data.consolidated_weather[0]);
        const upcomingDays = getUpcomingDaysForecast(data.consolidated_weather);
        setForecast({ currentDay: currentDay, currentDayDetails: currentDayDetails, upcomingDays: upcomingDays });
        setLoading(false);
    };
    
    const submitSearch = async (location) => {
        setLoading(true);
        setError(false);
    
        const response = await getWoeid(location);
        console.log(response)
        if (response == null) return;
        if (!response.woeid) return;
    
        const data = await getForecastData(response.woeid);
        if (!data) return;
    
        await gatherForecastData(data);
        
    };
    // useEffect(() => {    
    //     console.log('Forecast', forecast);
    // }, [forecast])
    return {
            isError,
            isLoading,
            submitSearch,
            forecast
        };
};