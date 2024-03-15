import { Button, Card, Checkbox, Flex, InputLabel, NumberInput, Progress, Slider, Text } from "@mantine/core"
import { useEffect, useRef, useState } from "react"
import { ColorType, IChartApi, UTCTimestamp, createChart } from 'lightweight-charts';

function Home() {
  const chartRef = useRef<HTMLDivElement>(null);
  const [chart, setChart] = useState<IChartApi | undefined>(undefined);

  const [kp, setKp] = useState(0);
  const [ki, setKi] = useState(0);
  const [kd, setKd] = useState(0);

  const [integral, setIntegral] = useState(0);
  const [derivative, setDerivative] = useState(0);
  const [error, setError] = useState(0);

  const [noise, setNoise] = useState(false);
  const [noiseRange, setNoiseRange] = useState(0);

  const onStartProcess = () => {

  }

  useEffect(() => {
    if (!chartRef.current) return;

    const _chart = createChart(chartRef.current, {
      autoSize: true,
      layout: {
        textColor: '#d1d4dc',
        background: {
          type: ColorType.Solid,
          color: '#000000',
        },
      },
      rightPriceScale: {
        scaleMargins: {
          top: 0.3,
          bottom: 0.25,
        },
      },
      crosshair: {
        vertLine: {
          width: 4,
          color: 'rgba(224, 227, 235, 0.1)',
          style: 0,
        },
        horzLine: {
          visible: false,
          labelVisible: false,
        },
      },
      grid: {
        vertLines: {
          color: 'rgba(42, 46, 57, 0)',
        },
        horzLines: {
          color: 'rgba(42, 46, 57, 0)',
        },
      },
    });

    setChart(_chart);

    const lineSeries = _chart.addLineSeries({ color: '#2962FF' });

    const data = [
      { value: 0, time: 1642425322 as UTCTimestamp },
      { value: 8, time: 1642511722 as UTCTimestamp },
      { value: 10, time: 1642598122 as UTCTimestamp },
      { value: 20, time: 1642684522 as UTCTimestamp },
      { value: 3, time: 1642770922 as UTCTimestamp },
      { value: 43, time: 1642857322 as UTCTimestamp },
      { value: 41, time: 1642943722 as UTCTimestamp },
      { value: 43, time: 1643030122 as UTCTimestamp },
      { value: 56, time: 1643116522 as UTCTimestamp },
      { value: 46, time: 1643202922 as UTCTimestamp },
    ];

    lineSeries.setData(data);

    _chart.timeScale().fitContent();

    return () => _chart.remove();
  }, []);

  return (
    <Flex direction="column" gap="xs" h="100%">

      <Flex justify="space-between" align="end" gap="xs">
        <Flex gap="xs">
          <NumberInput label="Kp" value={kp} onChange={(v) => setKp(Number(v))} />
          <NumberInput label="Ki" value={ki} onChange={(v) => setKi(Number(v))} />
          <NumberInput label="Kd" value={kd} onChange={(v) => setKd(Number(v))} />
        </Flex>

        <Button onClick={onStartProcess}>Start Process</Button>
      </Flex>

      <Flex gap="xs">

        <Flex direction="column" style={{ flex: 1 }}>
          <Text>{`PV (Process Value)`}</Text>
          <Progress size="xl" radius="sm" value={25} />

          <Text>{`SP (Set Point)`}</Text>
          <Slider />
        </Flex>

        <Flex direction="column" style={{ flex: 1 }}>
          <Text>{`MV (Output)`}</Text>
          <Progress size="xl" radius="sm" value={25} />

          <Text>{`Interval (ms)`}</Text>
          <Slider />
        </Flex>

      </Flex>

      <Flex align="center" gap="xs">
        <Checkbox label="Add Noise" checked={noise} onChange={(ev) => setNoise(ev.currentTarget.checked)} />
        <InputLabel size="x">Noise Range %</InputLabel>
        <NumberInput value={noiseRange} onChange={(v) => setNoiseRange(Number(v))} />
      </Flex>

      <Card withBorder p={0} style={{ flex: 1 }}>
        <Flex style={{ flex: 1 }}>
          <Flex ref={chartRef} style={{ flex: 1 }} />
          <Flex direction="column" p="xs" pos="absolute" style={{ zIndex: 1 }}>
            <Text>{`Integral ${integral}`}</Text>
            <Text>{`Derivative ${derivative}`}</Text>
            <Text>{`Error ${error}`}</Text>
          </Flex>
        </Flex>
      </Card>

    </Flex>
  )
}

export default Home