import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Weather } from './components/Weather';
import { Counter } from './components/Counter';
import WeatherPage from './components/WeatherForecast/PageWeather';
import PageWeather from "./components/WeatherForecast/PageWeather";

function App() {
    return (
        <div className="App">
            <PageWeather />
        </div>
    );
}

export default App;
// import './custom.css'
//
// export default class App extends Component {
//   static displayName = App.name;
//
//   render () {
//     return (
//       <Layout>
//         <Route exact path='/' component={Home} />
//         <Route path='/counter' component={Counter} />
//         <Route path='/weather' component={WeatherPage} />
//       </Layout>
//     );
//   }
// }

