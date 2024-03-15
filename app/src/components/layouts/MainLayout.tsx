import { Flex, useMantineTheme } from "@mantine/core";
import { Outlet } from "react-router-dom";

function MainLayout() {
  const theme = useMantineTheme();

  return (
    <Flex direction="column" p="xs" maw={theme.breakpoints.md} mx="auto">
      <Outlet />
    </Flex >
  )
}

export default MainLayout