import React, { Component } from 'react';

export class Weather extends Component {
  static displayName = Weather.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true, woeid: null, search: false };
    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(event) {
    this.setState({woeid: event.target.value});
  }

  handleSubmit(event) {
      var woeid = this.state.woeid;
      this.populateWeatherData(woeid);
    event.preventDefault();
  }
  
  componentDidMount() {
      this.setState({loading: false});
    //this.populateWeatherData();
  }
  
    static renderInputs(woeid, handleChange, handleSubmit) {
        return (
            <form onSubmit={handleSubmit}>
                <label>
                    Woei:
                    <input type="text" value={woeid} onChange={handleChange} />
                </label>
                <input type="submit" value="Search" />
            </form>
        )
    }
  
  static renderForecastsTable(forecasts) {
    return (
        <table className='table table-striped' aria-labelledby="tabelLabel">
          <thead>
          <tr>
            <th>Date</th>
            <th>Weather</th>
            <th>Min Temp. (C)</th>
            <th>Max Temp. (C)</th>
          </tr>
          </thead>
          <tbody>
          {forecasts.map(forecast =>
              <tr key={forecast.applicable_date}>
                <td>{forecast.applicable_date}</td>
                <td>{forecast.weather_state_name}</td>
                <td>{forecast.min_temp}</td>
                <td>{forecast.max_temp}</td>
              </tr>
          )}
          </tbody>
        </table>
    );
  }
  
  render() {
  let inputs = this.state.loading
      ? <p><em>Loading...</em></p>
      : Weather.renderInputs(this.state.woeid, this.handleChange, this.handleSubmit);
      
    let contents = !this.state.search
      ? <p><em></em></p>
      : Weather.renderForecastsTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
          {inputs}
        {contents}
      </div>
    );
  }

  async populateWeatherData(woeid) {
    const response = await fetch(`weatherforecast/${woeid}`);
    const data = await response.json();
    this.setState({ forecasts: data.consolidated_weather.length > 5 ? data.consolidated_weather.slice(0, 5) : data.consolidated_weather, loading: false, search: true });
  }
}
