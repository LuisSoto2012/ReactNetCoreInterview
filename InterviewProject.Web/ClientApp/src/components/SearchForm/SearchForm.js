import React, { useState } from 'react';
import styles from './SearchForm.module.css';

const SearchForm = ({submitSearch}) => {
    const [location, setLocation] = useState('');
    
    const onSubmit = (e) => {
        e.preventDefault();
        if (!location || location === '') return;
        submitSearch(location);
    };
    return (
        <form onSubmit={onSubmit}>
            <input
                aria-label="location"
                type="text"
                className={`${styles.input} form-control`}
                placeholder="Enter location"
                value={location}
                onChange={(e) => setLocation(e.target.value)}
                required
            />

            <button type="submit" className={styles.button} onClick={onSubmit}>
                Search!
            </button>
        </form>
    );
};

export default SearchForm;