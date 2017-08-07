-- 將資料從IoT Hub寫入至資料庫
SELECT
    DeviceId, Temperature, Humidity, PM25, SendDateTime
INTO
    [ToDb]
FROM
    [FromIoT]
    
-- 將資料從IoT Hub寫入至儲存體
SELECT
    *
INTO
    [ToStorage]
FROM
    [FromIoT]
    
-- 將資料從IoT Hub寫入至服務匯流排佇列
SELECT
    DeviceId, Temperature, Humidity, PM25, SendDateTime
INTO
    [ToServiceBus]
FROM
    [FromIoT]

-- 將資料寫入至PowerBI的資料集中
SELECT
    DeviceId, Temperature, Humidity, PM25, SendDateTime as time
INTO
    [ToPowerBI]
FROM
    [FromIoT]