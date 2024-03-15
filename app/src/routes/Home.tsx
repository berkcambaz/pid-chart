import { Button, Checkbox, Flex, InputLabel, NumberInput, Progress, Slider, Text, TextInput } from "@mantine/core"

function Home() {
  return (
    <Flex direction="column" gap="xs">

      <Flex justify="space-between" align="end" gap="xs">
        <Flex gap="xs">
          <TextInput label="Kp" />
          <TextInput label="Ki" />
          <TextInput label="Kd" />
        </Flex>

        <Button>Start Process</Button>
      </Flex>

      <Flex gap="xs">

        <Flex direction="column" style={{ flex: 1 }}>
          <Text>{`PV (Process Value)`}</Text>
          <Progress size="xl" radius="sm" value={25} />

          <Text>{`SP (Set Point)`}</Text>
          <Slider />
        </Flex>

        <Flex direction="column" style={{ flex: 1 }}>
          <Text>{`MV (output)`}</Text>
          <Progress size="xl" radius="sm" value={25} />

          <Text>{`Interval (ms)`}</Text>
          <Slider />
        </Flex>

      </Flex>

      <Flex gap="xs">
        <Text>Integral 100</Text>
        <Text>Derivative 100</Text>
        <Text>Error 100</Text>
      </Flex>

      <Flex align="center" gap="xs">
        <Checkbox label="Add Noise" />
        <InputLabel size="x">Noise Range %</InputLabel>
        <NumberInput />
      </Flex>

    </Flex>
  )
}

export default Home