CREATE TABLE schedules (
  id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  train_id INT NOT NULL,
  origin_station_id INT NOT NULL,
  destination_station_id INT NOT NULL,
  departure_time DATETIME2 NOT NULL,
  arrival_time DATETIME2 NOT NULL,
  FOREIGN KEY (train_id) REFERENCES trains(id),
  FOREIGN KEY (origin_station_id) REFERENCES stations(id),
  FOREIGN KEY (destination_station_id) REFERENCES stations(id)
);